using System.Collections.Generic;
using System.IO;
using System.Linq;
using NRApiClient.Models;

namespace NRApiClient.Helpers
{
    public static class DataMapper
    {
        public static List<CSVData> getMappedDataFromCSV(string filelocation)
        {
            List<CSVData> csvData = new List<CSVData>();
            using (var reader = new StreamReader(filelocation))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    CSVData record = new CSVData()
                    {
                        RespondentId = values[0],
                        InterviewDate = values[1],
                        Weight = values[2],
                        Hfilter = values[3],
                        BgSubscrType = values[4],
                        BgAgegroup = values[5],
                        BgGender = values[6],
                        BgIncome = values[7],
                        BrAwaToM = values[8],
                        BrAwaIM1 = values[9],
                        BrAwaIM2 = values[10],
                        BrAwaIM3 = values[11],
                        BrAwaIM4 = values[12],
                        BrAwaIM5 = values[13],
                        BrAwaIM6 = values[14],
                        BrAwaIM7 = values[15],
                        BrAwaIM8 = values[16],
                        BrAwaIM9 = values[17],
                        BrAwaIM10 = values[18],
                        BrAwaIM11 = values[19],
                        BrAwaIM12 = values[20],
                        AwaAdRecToM = values[21],
                        AwaAdRecIM1 = values[22],
                        AwaAdRecIM2 = values[23],
                        AwaAdRecIM3 = values[24],
                        AwaAdRecIM4 = values[25],
                        AwaAdRecIM5 = values[26],
                        AwaAdRecIM6 = values[27],
                        AwaAdRecIM7 = values[28],
                        AwaAdRecIM8 = values[29],
                        AwaAdRecIM9 = values[30],
                        AwaAdRecIM10 = values[31],
                        AwaAdRecIM11 = values[32],
                        AwaAdRecIM12 = values[33],
                        Cons1 = values[34],
                        Cons2 = values[35],
                        Cons3 = values[36],
                        Cons4 = values[37],
                        Cons5 = values[38],
                        Cons6 = values[39],
                        Cons7 = values[40],
                        Cons8 = values[41],
                        Cons9 = values[42],
                        Cons10 = values[43]
                    };
                    csvData.Add(record);
                }
            }
            return csvData;
        }
        public static List<Models.JSONModel._MetaData> getMetadataForImport()
        {
            List<Models.JSONModel._MetaData> metadataList = new List<JSONModel._MetaData>();
            Models.JSONModel._MetaData metadataRecord = new Models.JSONModel._MetaData();

            metadataRecord.Code = "RespondentID";
            metadataRecord.Text = "Respondent ID";
            metadataRecord.Type = "OpenNumeric";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "InterviewDate";
            metadataRecord.Text = "Interview Date";
            metadataRecord.Type = "DateTime";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Weight";
            metadataRecord.Text = "Weight";
            metadataRecord.Type = "OpenNumeric";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Hfilter";
            metadataRecord.Text = "Hfilter";
            metadataRecord.Type = "OpenString";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "BgSubscrType";
            metadataRecord.Text = "BgSubscrType";
            metadataRecord.Type = "OpenString";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "BgAgegroup";
            metadataRecord.Text = "BgAgegroup";
            metadataRecord.Type = "OpenString";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "BgGender";
            metadataRecord.Text = "BgGender";
            metadataRecord.Type = "OpenString";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "BgIncome";
            metadataRecord.Text = "BgIncome";
            metadataRecord.Type = "OpenString";
            metadataRecord.AnswerAlternatives = null;
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "BrAwaToM";
            metadataRecord.Text = "BrAwaToM";
            metadataRecord.Type = "MultiChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "Dapresy Telecom"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "Don't know"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "DonkyCom"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "Donut Call"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "Duty Calls"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "6",
                        Text = "Four"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "7",
                        Text = "Swedish Telecom"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "8",
                        Text = "Sweet Talk"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "9",
                        Text = "Tel Me More"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "10",
                        Text = "Telecom for You"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "11",
                        Text = "WTC"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "12",
                        Text = "Other"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "AwaAdRecToM";
            metadataRecord.Text = "AwaAdRecToM";
            metadataRecord.Type = "MultiChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "Dapresy Telecom"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "Don't know"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "DonkyCom"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "Donut Call"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "Duty Calls"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "6",
                        Text = "Four"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "7",
                        Text = "Swedish Telecom"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "8",
                        Text = "Sweet Talk"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "9",
                        Text = "Tel Me More"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "10",
                        Text = "Telecom for You"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "11",
                        Text = "WTC"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "12",
                        Text = "Other"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons1";
            metadataRecord.Text = "Cons1";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons2";
            metadataRecord.Text = "Cons2";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons3";
            metadataRecord.Text = "Cons3";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons4";
            metadataRecord.Text = "Cons4";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons5";
            metadataRecord.Text = "Cons5";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons6";
            metadataRecord.Text = "Cons6";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons7";
            metadataRecord.Text = "Cons7";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons8";
            metadataRecord.Text = "Cons8";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons9";
            metadataRecord.Text = "Cons9";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            metadataRecord = new Models.JSONModel._MetaData();
            metadataRecord.Code = "Cons10";
            metadataRecord.Text = "Cons10";
            metadataRecord.Type = "SingleChoice";
            metadataRecord.AnswerAlternatives = new List<Models.JSONModel._MetaData.AnswerAlternative>()
                {
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "1",
                        Text = "1 Not at all likely"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "2",
                        Text = "2"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "3",
                        Text = "3"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "4",
                        Text = "4"
                    },
                    new JSONModel._MetaData.AnswerAlternative()
                    {
                        Code = "5",
                        Text = "5 Very likely"
                    }
                };
            metadataList.Add(metadataRecord);

            return metadataList;
        }
        public static List<Models.JSONModel._CaseData> getCasedataForImport(List<CSVData> csvdata)
        {
            List<Models.JSONModel._CaseData> casedataList = new List<JSONModel._CaseData>();
            
            Dictionary<string, string> singleChoiceVals = new Dictionary<string, string>();
            singleChoiceVals.Add("1", "1 Not at all likely");
            singleChoiceVals.Add("2", "2");
            singleChoiceVals.Add("3", "3");
            singleChoiceVals.Add("4", "4");
            singleChoiceVals.Add("5", "5 Very likely");

            Dictionary<string, string> multiChoiceVals = new Dictionary<string, string>();
            multiChoiceVals.Add("1", "Dapresy Telecom");
            multiChoiceVals.Add("2", "Don't know");
            multiChoiceVals.Add("3", "DonkyCom");
            multiChoiceVals.Add("4", "Donut Call");
            multiChoiceVals.Add("5", "Duty Calls");
            multiChoiceVals.Add("6", "Four");
            multiChoiceVals.Add("7", "Swedish Telecom");
            multiChoiceVals.Add("8", "Sweet Talk");
            multiChoiceVals.Add("9", "Tel Me More");
            multiChoiceVals.Add("10", "Telecom for You");
            multiChoiceVals.Add("11", "WTC");
            multiChoiceVals.Add("12", "Other");

            foreach (CSVData record in csvdata.Skip(1))
            {
                List<string> multiAnswers = new List<string>();
                List<string> singleAnswer = new List<string>();
                Models.JSONModel._CaseData currentRecord = new JSONModel._CaseData();
                currentRecord.RespondentID = record.RespondentId;
                currentRecord.InterviewDate = record.InterviewDate;
                currentRecord.Weight = record.Weight;
                currentRecord.Hfilter = record.Hfilter;
                currentRecord.BgSubscrType = record.BgSubscrType;
                currentRecord.BgAgegroup = record.BgAgegroup;
                currentRecord.BgGender = record.BgGender;
                currentRecord.BgIncome = record.BgIncome;

                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM1).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM2).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM3).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM4).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM5).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM6).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM7).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM8).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM9).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM10).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM11).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.BrAwaIM12).Select(x => x.Key).FirstOrDefault());
                currentRecord.BrAwaToM = multiAnswers.Where(x => x != null).ToArray();

                multiAnswers = new List<string>();
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM1).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM2).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM3).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM4).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM5).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM6).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM7).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM8).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM9).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM10).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM11).Select(x => x.Key).FirstOrDefault());
                multiAnswers.Add(multiChoiceVals.Where(x => x.Value == record.AwaAdRecIM12).Select(x => x.Key).FirstOrDefault());
                currentRecord.AwaAdRecToM = multiAnswers.Where(x => x != null).ToArray();

                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons1).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons1 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons2).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons2 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons3).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons3 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons4).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons4 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons5).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons5 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons6).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons6 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons7).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons7 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons8).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons8 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons9).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons9 = singleAnswer.Where(x => x != null).ToArray();

                singleAnswer = new List<string>();
                singleAnswer.Add(singleChoiceVals.Where(x => x.Value == record.Cons10).Select(x => x.Key).FirstOrDefault());
                currentRecord.Cons10 = singleAnswer.Where(x => x != null).ToArray();

                casedataList.Add(currentRecord);
            }

            return casedataList;

        }
    }
}
