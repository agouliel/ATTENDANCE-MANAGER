using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AttLilbraryClient
{
    class Program
    {

        private static void LogCreation(SqlConnection con,string filename,string purpose)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Demo (AName,ADate,Purpose) values(@aname,@adate,@purpose)");
                cmd.Parameters.Add("@aname", SqlDbType.VarChar).Value = filename;
                cmd.Parameters.Add("@adate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@purpose", SqlDbType.VarChar).Value = purpose;

                
                cmd.Connection = con;

                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }




        }

        private static void CheckName(SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from ");
                cmd.CommandText += "D";
                cmd.CommandText += "ME".Substring(1);
                cmd.CommandText += "fffM".Substring(3);
                cmd.CommandText += "22343O".Substring(5);
                cmd.Connection = con;

                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(new DataTable());
            }
            catch
            {
                throw;
            }
            



        }



        static void Main(string[] args)
        {
            //  )!(@*#&$^%!@#$%^&*()(*&^%$#@!";
               
            //")!(@*#&$^21!@#$%^&*()(*&^%$#@!"


            //")!(@*#&$^%!@#$%^&*()(*&^%$#@!";
            string ipassword = ")1!5(3@4*6#7&8$9^1%31!17@15#13$23%33^45&34*64(64)65(65*64&23^34%45$33#12@09!";
            string password = "";

            //string constr = @"Data Source=192.168.0.178,1433\SQLSERVER;Initial Catalog=AttendanceV1;User ID=AttendanceUser;password=jesuschristwins";

            string constr = "k/WeWpYKPGrYP7sUBqCReRvasRCvhIGvZJOdRj+aZmBB2+WxnC8bO77pyvDKCEEQQKzpH7Y0wDfVB056hH32lQ6T9+DJqwXtKPWsN8Abz8VebZ80GdyyZ0xDPAGP5jTwMZw0BhCQmafHXgDGfO2uUJvsIjxj71idn+GE8bzuyWs=";

              string VI = "ABSDEFGHIJKLMOPQ";
                        string p = "!2@PI#OJP#OIJklj;k;2pjp8ijP(*jwspiopsjp8(*j98j";
                        string s = "@6(&^(#YYGHKHGT&^GIGIOYJLJHP*&YJHLJHLHJHIYO&^&^&*^T";




                        string cipherdata = "";
                       // cipherdata=SMEncryption.RijndaelSimple.Encrypt(constr, p, s, "SHA1", 3, VI, 192);
                     //   Console.Error.WriteLine(cipherdata);
                    //    cipherdata = set.ConnectionString;
                     /*   
                        System.IO.TextWriter tr = new StreamWriter("c:\\Credentials.txt");
                        tr.WriteLine(set.Name+"     "+set.ConnectionString);
                        tr.WriteLine(">");
                        tr.WriteLine(cipherdata);
                        tr.WriteLine("<");
                        tr.Close();
                      */ 
  //                      return set.ConnectionString;
                      


                        cipherdata = constr;
                        string t_dec = SMEncryption.RijndaelSimple.Decrypt(cipherdata, p, s, "SHA1", 3, VI, 192);
                        //MessageBox.Show(t_dec);



                        Console.WriteLine("Briefcase Exporter\n");
                        Console.WriteLine("Utility will be valid until 31-07-2009\n\n");




            SqlConnection con=new SqlConnection(t_dec);




            try{
                con.Open();
                
                int intArgCount=0;
                intArgCount=args.GetLength(0);
                if ( intArgCount!= 1)
                {
                    Console.WriteLine("Proper syntax");
                    Console.WriteLine("<FileName>,\nwhere <FileName> :Name of the file that is going to be created (without any suffix)");
                    Console.In.ReadLine();
                    return;

                }


                int idx=0;
                for (int ii = 0; ii < 29; ii++)
                {
                    password += ipassword[idx];
                    if (ii - 9 >= 0)
                        idx += 3;
                    else
                        idx += 2;
                }

                Program.CheckName(con);

                string strFileName = args[0].Trim()+"_From_"+DateTime.Now.ToString("dd-MM-yyyy")+"_To_"+(DateTime.Now.AddMonths(1)).ToString("dd-MM-yyyy") + ".sdf";
                
                    Console.WriteLine("Creating Briefcase file : " + strFileName);
                


                DataTable dtQs = AttLibrary.Questionnaire.Select(con);
                int i = 0;
                foreach (DataRow dr in dtQs.Rows)
                {
                    i++;
                    Console.WriteLine(string.Format("{0}   {1}",i,dr["Title"]));
                }


                Console.Out.WriteLine("\nPlease select Vetting (V) or Attendance (A) procedure ? ");



                int mode=0;
                int[] intAr = null;
                string InputStr=Console.ReadLine();
                if (InputStr.Trim().ToUpper() == "A")
                {
                    mode = 0;
                    intAr = new int[1];
                    intAr[0] = 4;
                }
                else if (InputStr.Trim().ToUpper() == "V")
                {
                    mode = 1;
                    intAr = new int[3];
                    intAr[0] = 1;
                    intAr[1] = 2;
                    intAr[2] = 3;

                }
                else
                {
                    Console.Out.WriteLine("Invalid Procedure selected\n\n");
                    Console.Out.WriteLine("Press a key to continue...");
                    Console.ReadLine();
                    return;
                }



                Console.WriteLine("\nPlease verify the usage of the file and afterwards press <Enter>");


                string strPurpose = Console.ReadLine();

                Console.WriteLine("\nPlease enter the name of our company's representative and press <Enter>");
                string strRepr = Console.ReadLine();



                if (strRepr.Trim() == "")
                {
                    Console.WriteLine("Invalid representative's name");
                    throw new Exception("");
                }

                strPurpose += " "+strRepr;

                


                bool berror = false;


                /*
                string [] strAr= InputStr.Split(new char[] { ',' });


                int [] intAr=new int[strAr.GetLength(0)];
             bool berror = false;

                for (int j = 0; j < strAr.Count<string>();j++ )
                {
                    intAr[j] = Convert.ToInt32(strAr[j]);

                    if (intAr[j]>dtQs.Rows.Count)
                    {

                        berror = true;
                        break;
                    }
                }
                 */ 
                if (!berror)
                {
                    Console.WriteLine("The following questionnaires are going to be included :");
                    foreach (int r in intAr)
                    {
                        DataRow dr = dtQs.Rows[r - 1];
                        Console.WriteLine(string.Format("{0}   {1}", r, dr["Title"]));
                        object o=dr["SecurityColumn"];
                    }
                }
                Console.WriteLine("\n");

                if (!berror)
                {
                    try
                    {
                        AttLibrary.Portable.SaveSchema(strFileName, password,false);

                    }
                    catch (Exception e2)
                    {
                        Console.Out.WriteLine("Metadata failed to be exported :" + e2.Message);
                        return;
                    }

                    if (!AttLibrary.Questionnaire.TransferRegistryInfoToBriefcase(con, strFileName, password))
                    {

                        Console.Out.WriteLine("Registry data failed to be transfered.");

                        return;
                    }
                    foreach (int r in intAr)
                    {
                        DataRow dr = dtQs.Rows[r - 1];
                        
                        int qid = (int)dr["Qid"];
                        try
                        {
                            if ((byte)dr["finalized"] != 1)
                            {
                                throw new Exception("not finalized");
                            }
                        }
                        catch (Exception e3)
                        {
                            Console.WriteLine(dr["Qid"].ToString() + " skipped :not finalized");
                            continue;

                        }

                        string msg = "";
                        try
                        {
                            AttLibrary.Portable.TransferQuestionnaireTemplate(con, qid, strFileName, password,out msg);
                        }
                        catch (Exception e2)
                        {
                            Console.Out.WriteLine("Questionnaire export failed :" + e2.Message);
                        }
                    }

                    try
                    {
                        strPurpose+=" Host Name : "+System.Net.Dns.GetHostName();
                    }
                    catch { }

                    LogCreation(con, strFileName,strPurpose);
                    Console.Out.WriteLine(string.Format("Briefcase file {0} created.", strFileName));



                }


                Console.Out.WriteLine("Print a key to continue ...");

                Console.In.ReadLine();

            }
            catch(Exception e1)
            {
                Console.Out.WriteLine("Critical error occured.");
                return;
            }

        }




    }


}
