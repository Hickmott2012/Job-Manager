//Programer: Benjamin Hickmott
//Project Name: Job Manager
//Start Date: 02/27/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using GlobalVariables;

namespace TimeSheetProgram
{
    class jobControls
    {
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string JOBFILEEXTENSHION = GlobalVars.JOBFILEEXTENSHION;
        public const string JOBCODESFILE = GlobalVars.JOBCODESFILE;
        public const string TEMPFILE = GlobalVars.TEMPFILE;
        public const char DELIM = ',';
        private string userFolder;
        private string jobNumber;
        private string jobName;
        private DateTime startDate;
        private DateTime endDate;
        private string recordInText;
        public string[] jobEmployees;
        private string jobCode;
        private double jobEstimateCost;
        private string jobStatus;
        private string jobNotes;

        public string UserFolder
        {
            get
            {
                return userFolder;
            }
            set
            {
                userFolder = value;
            }
        }

        public string DirectoryName
        {
            get
            {
                return REQUIREDFOLDER + UserFolder + "\\"; ;
            }
        }

        public string JobNumber
        {
            get
            {
                return jobNumber;
            }
            set
            {
                jobNumber = value;
            }
        }

        public string JobName
        {
            get
            {
                return jobName;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
        }

        public string JobCode
        {
            get
            {
                return jobCode;
            }
        }

        public double JobEstimateCost
        {
            get
            {
                return jobEstimateCost;
            }
        }

        public string JobStatus
        {
            get
            {
                return jobStatus;
            }
        }

        public string JobNotes
        {
            get
            {
                return jobNotes;
            }
        }

        public jobControls(string UserName)
        {
            UserFolder = UserName;
        }

        public void newJob(string jobName, string recievedJobNumber)
        {
            string newJobDirectory;
            newJobDirectory = DirectoryName + recievedJobNumber + JOBFILEEXTENSHION;
            FileStream creatJob = new FileStream(newJobDirectory, FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(creatJob);
            write.WriteLine(jobName);
            write.WriteLine("JOB");
            write.WriteLine(DateTime.Now);
            write.WriteLine(DateTime.Now);
            write.WriteLine("");
            write.WriteLine(0);
            write.WriteLine("No Job Selcted");
            write.Write("");
            write.Close();
            creatJob.Close();
        }

        public void deleteJob(string selectedJobNumber)
        {
            string fileToDelete = DirectoryName + selectedJobNumber + JOBFILEEXTENSHION;
            try
            {
                File.Delete(fileToDelete);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error: File Could Not Be Found to Delete");
            }
        }

        public void saveJob(string recievedJobName, string recievedJobNumber, DateTime recievedStartDate, DateTime recievedEndDate,
                    string[] recievedJobEmployees, string recievedJobCode, double recievedJobEstimateCost,
            string reciededJobStatus, string recievedJobNotes)
        {
            jobName = recievedJobName;
            jobNumber = recievedJobNumber;
            startDate = recievedStartDate;
            endDate = recievedEndDate;
            jobEmployees = recievedJobEmployees;
            jobCode = recievedJobCode;
            jobEstimateCost = recievedJobEstimateCost;
            jobStatus = reciededJobStatus;
            jobNotes = recievedJobNotes;

            string jobNameToSave = DirectoryName + JobNumber + JOBFILEEXTENSHION;
            try
            {
                FileStream saveJob = new FileStream(jobNameToSave, FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter(saveJob);

                write.WriteLine(JobName);
                write.WriteLine(jobCode);
                write.WriteLine(startDate);
                write.WriteLine(endDate);
                if (jobEmployees.Length > 0)
                {
                    write.Write(jobEmployees[0]);

                    for (int i = 1; i < jobEmployees.Length; i++)
                    {
                        write.Write(DELIM + jobEmployees[i]);
                    }
                }
                write.WriteLine();
                write.WriteLine(jobEstimateCost);
                write.WriteLine(jobStatus);
                write.Write(jobNotes);

                write.Close();
                saveJob.Close();
            }
            catch
            {
                MessageBox.Show("Error: Job File Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void loadJob(string jobNumber)
        {
            //Fill Variables with information
            string jobNameToLoad = DirectoryName + jobNumber + JOBFILEEXTENSHION;
            FileStream loadSelectedJob = new FileStream(jobNameToLoad,
            FileMode.Open, FileAccess.Read);
            StreamReader Read = new StreamReader(loadSelectedJob);

            loadSelectedJob.Seek(0, SeekOrigin.Begin);
            jobName = Read.ReadLine();
            jobCode = Read.ReadLine();
            startDate = Convert.ToDateTime(Read.ReadLine());
            endDate = Convert.ToDateTime(Read.ReadLine());

            recordInText = Read.ReadLine();
            if (recordInText != "" && recordInText != null)
            {
                jobEmployees = recordInText.Split(DELIM);
            }

            jobEstimateCost = Convert.ToDouble(Read.ReadLine());
            jobStatus = Read.ReadLine();
            jobNotes = Read.ReadToEnd();

            Read.Close();
            loadSelectedJob.Close();
        }

        public void editJob(string currentJobNumber, string currentJobName)
        {
            newJobFrm changeJobName = new newJobFrm();
            changeJobName.ShowDialog();
            if (changeJobName.DialogResult == DialogResult.OK)
            {
                jobName = changeJobName.ReturnJobName;
                jobNumber = changeJobName.ReturnJobNumber;
                File.Move(DirectoryName + currentJobNumber + JOBFILEEXTENSHION, DirectoryName + jobNumber + JOBFILEEXTENSHION);
                string jobNumberToChangeName = DirectoryName + jobNumber + JOBFILEEXTENSHION;
                string text = File.ReadAllText(jobNumberToChangeName);
                text = text.Replace(currentJobName, jobName);
                File.WriteAllText(jobNumberToChangeName, text);
            }
            else
            {
                jobNumber = currentJobNumber;
            }
        }

        public void deleteJobCode(string jobCodeToDelete)
        {
            StreamReader read = new StreamReader(REQUIREDFOLDER + JOBCODESFILE);
            StreamWriter writer = new StreamWriter(TEMPFILE);
            string codes;

            while ((codes = read.ReadLine()) != null)
            {
                if (codes != jobCodeToDelete)
                {
                    writer.WriteLine(codes);
                }
            }
            
            read.Close();
            writer.Close();
            File.Delete(REQUIREDFOLDER + JOBCODESFILE);
            File.Move(TEMPFILE, REQUIREDFOLDER + JOBCODESFILE);
        }

        public void addJobCode(string jobCodeToAdd)
        {
            FileStream addNewJobCodeToFile = new FileStream(REQUIREDFOLDER + JOBCODESFILE, FileMode.Append);
            StreamWriter writer = new StreamWriter(addNewJobCodeToFile);
            writer.WriteLine(jobCodeToAdd);
            writer.Close();
        }
    }
}

