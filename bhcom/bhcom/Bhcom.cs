using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows;
using System.EnterpriseServices;
using System.Xml;


namespace bhcom
{

    [Guid("A2C829EB-32D0-4163-B0DA-85EE902957EE")]
    


        public interface  Invk_Interface
        {

         string invokgetproddep(ref string[] prodnovar, ref string[] prodnamevar, ref string[] prodsizevar, ref string[] lastaddvar, ref double[] retailpricevar, ref int[] belongtovar, ref int[] prodpervar, string wcfaddr, string theusername, string thepw);

         string invokmyuploadgjd(string listnomainvar, string clinomainvar, DateTime localtimemainvar, int belongtomainvar, int nowstatusmainvar, string[] listnosubvar, string[] prodnosubvar, double[] neednumsubvar, int[] statusubvar, DateTime[] lesttimevar, string wcfaddr, string theusername, string thepw);

         string invokgetinvmaininfo(DateTime begintimemain, DateTime endtimemain, string clinomain, int belongtomain, ref string[] listnomainvar, ref string[] clinomainvar, ref string[] clinamemainvar, ref DateTime[] invdatemainvar, ref double[] invmonmainvar, ref string[] invmemomainvar, string wcfaddr, string theusername, string thepw);

         string invokgetinvsubinfo(string listnosubvar, int belongtosubvar, ref string[] invsubprodnovar, ref string[] invsubprodnamevar, ref string[] invsubprodsizevar, ref string[] invsubmonadvar, ref string[] invsubboxnumvar, ref string[] invsubwarenovar, ref string[] invsubprodaddvar, ref string[] invsubbatchnovar, ref double[] invsubinvnumvar, ref double[] invsubstdprice, ref double[] invsubsellpricevar, ref DateTime[] invsubavaildatevar, ref double[] invsubretailpricevar, ref string[] invsubprodmade, ref string[] invsubprodlabelvar, ref string[] invsubprodpzwhvar, ref string[] invsubboxmidnum, ref string[] invsubbarcode, string wcfaddr, string theusername, string thepw);

         string invokclientinfo(ref string[] clientclinovar, ref string[] clientname, ref double[] clientsumjf, ref string[] clientadd, ref string[] clientclitelvar,  ref string[] clientclimemo, ref string[] clientsex, string wcfaddr, string theusername, string thepw);

        string invokclientinfover2(ref string[] clientclinovar, ref string[] clientname, ref double[] clientsumjf, ref string[] clientadd, ref string[] clientclitelvar, ref string[] clientclimemo, ref string[] clientsex, ref string[] cliass, ref double[] cliper, ref string[] clienttypeno, ref int[] jf, ref int[] nl, ref int[] prjf, string wcfaddr, string theusername, string thepw);

         string invokGetboxmidnum(ref string[] prodnovar, ref string[] prodnamevar, ref string[] boxmidnumvar, string wcfaddr, string theusername, string thepw);

         string invokProdfull(ref string[] prodnovar, ref string[] prodnamevar, ref string[] prodsizevar, ref string[] monadvar, ref string[] lastaddvar, ref string[] barcodevar, ref string[] prodpzwhvar, ref double[] stdpricevar, ref double[] retailpricevar, ref string[] prodmadevar, ref string[] prodlabelvar, ref bool[] sellstopvar, string wcfaddr, string theusername, string thepw);

         string invokProdfullsingle(int mybleongto,ref string[] prodnovar, ref string[] prodnamevar, ref string[] prodsizevar, ref string[] monadvar, ref string[] lastaddvar, ref string[] barcodevar, ref string[] prodpzwhvar, ref double[] stdpricevar, ref double[] retailpricevar, ref string[] prodmadevar, ref string[] prodlabelvar, ref bool[] sellstopvar, string wcfaddr, string theusername, string thepw);
        
         string invokGetProdrecip(ref string[] prodnovar, ref string[] prodnamevar, ref bool[] recipevar, string wcfaddr, string theusername, string thepw);

         string invokSimilarProdname(ref string[] prodnofir, ref string[] prodnamefir, ref string[] prodsizefir, ref string[] monadfir, ref bool[] llstopfir, ref string[] lastaddfir, ref string[] prodnasecfir, ref double[] depnumfir, ref  string[] belongfir, ref double[] buypricefir, ref string[] prodnosec, ref string[] prodnamesec, ref string[] prodsizesec, ref string[] monadsec, ref bool[] llstopsec, ref string[] lastaddsec, ref string[] prodnasecsec, ref double[] depnumsec, ref  string[] belongsec, ref double[] buypricesec, string wcfaddr, string theusername, string thepw);

         string invokgetservertime(ref DateTime myservertime, string wcfaddr, string theusername, string thepw);

         double calthesimarlar(string strtargetone, string strtargetwo);

         int invokeuploadfiveprod(string[] listnovar, DateTime[] invdatevar, string[] prodnovar, string[] prodnamevar, string[] prodaddvar, string[] batchnovar, double[] invnumvar, double[] stdpricevar, double[] sellpricevar, string[] clinovar, string[] invbywhovar, string[] mdnovar, string wcfaddr, string theusername, string thepw);
         
         int invokemyuploadgjdver2(string listnomain, string clinomain, string clinozymain, DateTime localtimemain, int nowstatusmain, string[] listnosub, string[] prodnosub, string[] prodnamesub, string[] lastaddsub, double[] neednumsub, int[] statusub, DateTime[] lesttimesub, ref string[] gjdnolack, ref string[] prodnolack, ref int[] reasonlack, string wcfaddr, string theusername, string thepw);
         
         int invokecheckkcbelong(string[] prodno, string[] prodname, string[] lastadd, string[] monad, ref string[] prodnoret, ref int[] belongtoret, string cli_no, string wcfaddr, string theusername, string thepw);
         
         int invokeUploadthekc(string listnomain, string clinomain, string clinozymain, int nowstatusmain, string[] lnumno, string[] prodno, double[] stdprice, double[] invnum, DateTime[] depdate, double[] lestnum, double[] lnum, int[] theblongto, string wcfaddr, string theusername, string thepw);
         
         int invokecheckretbelong(string[] prodno, string[] prodname, string[] lastadd, string[] batchno, string[] monad, ref string[] prodnoret, ref string[] batchnoret, ref int[] belongtoret, string cli_no, string wcfaddr, string theusername, string thepw);
         
         int invokeUploadtheret(string listnomain, string clinomain, string clinozymain, int nowstatusmain, string[] lnumno, string[] prodno, string[] prodadd, string[] batchno, double[] retnum, double[] buyprice, double[] stdprice, int[] belongto, string wcfaddr, string theusername, string thepw);
         
         int getheautodepbz(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref int[] bz, string wcfaddr, string theusername, string thepw);
         
         int getheprodbth(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref string[] bz, string wcfaddr, string theusername, string thepw);
         
         int getheoldgf(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref string[] gf, string wcfaddr, string theusername, string thepw);


         int getheoldgfsingle(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref string[] gf,int thedb, string wcfaddr, string theusername, string thepw);

         int gethenewgf(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref double[] gf, string wcfaddr, string theusername, string thepw);
         
         int uploaddep(string[] prodno, string[] prodname, string[] prodadd, string[] batchno, double[] lestnum, string[] boxnum, DateTime[] availdate, double[] stdprice, string clino, string wcfaddr, string theusername, string thepw);
         
          int uploadchgprice(DateTime[] changedate, string[] prodno, string[] prodname, string[] prodsize, string[] prodadd, string[] batchno, string[] monad, double[] lestnum, double[] oldstdprice, double[] newstdprice, string clino, int softwaretype, string wcfaddr, string theusername, string thepw);

          int getinvfull(DateTime begtime, DateTime endtime, string cli_no, int thebelong, int pageSize, int pageIndex, ref string counts, ref string pagecounts, ref string[] listno, ref  DateTime[] invdate, ref  string[] prodno, ref  string[] prodname, ref  string[] prodsize, ref  string[] prodadd, ref  string[] monad, ref  string[] batchno, ref  DateTime[] availdate, ref  double[] invnum, ref  double[] sellprice, ref  double[] retailprice, ref  string[] prodpzwh, string wcfaddr, string theusername, string thepw);

          int getdepinfo(int thebelong, ref  string[] prodno, ref  string[] prodname, ref   string[] prodsize, ref   string[] monad, ref   string[] batchno, ref  string[] prodadd, ref   double[] lestnum, ref  DateTime[] availdate, string wcfaddr, string theusername, string thepw);
         
        string gettheupdate(string webaddr);

        string invokgetinvsubinfo2(string listnosubvar, int belongtosubvar, ref string[] invsubprodnovar, ref string[] invsubprodnamevar, ref string[] invsubprodsizevar, ref string[] invsubmonadvar, ref string[] invsubboxnumvar, ref string[] invsubwarenovar, ref string[] invsubprodaddvar, ref string[] invsubbatchnovar, ref double[] invsubinvnumvar, ref double[] invsubstdprice, ref double[] invsubsellpricevar, ref DateTime[] invsubavaildatevar, ref double[] invsubretailpricevar, ref string[] invsubprodmade, ref string[] invsubprodlabelvar, ref string[] invsubprodpzwhvar, ref string[] invsubboxmidnum, ref string[] invsubbarcode,ref DateTime[] invsubproducedate, string wcfaddr, string theusername, string thepw);

         
     }



     [Guid("65C379D9-F7FC-49a6-8776-0BAEA0341E6A")]
     [ClassInterface(ClassInterfaceType.None)]
     public class Bhclass : ServicedComponent, Invk_Interface
    {


         public string invokgetproddep(ref string[] prodnovar, ref string[] prodnamevar, ref string[] prodsizevar, ref string[] lastaddvar, ref double[] retailpricevar, ref int[] belongtovar, ref int[] prodpervar, string wcfaddr, string theusername, string thepw)
         {


             WCFServiceWrapper.Proddepinfostruct[] proddeplist = new WCFServiceWrapper.Proddepinfostruct[9000];
         

            try
            {
                thepw = getthemd5string(thepw);
                proddeplist = WCFServiceWrapper.SvcWrapper.invokgetproddep(wcfaddr, theusername, thepw);
                int rowcount = proddeplist.Length;
                prodnovar = new string[rowcount];
                prodnamevar = new string[rowcount];
                prodsizevar = new string[rowcount];
                lastaddvar = new string[rowcount];
                retailpricevar = new double[rowcount];
                belongtovar = new int[rowcount];
                prodpervar = new int[rowcount];

                int i = 0;
                for (i = 0; i < rowcount; i++)
                {
                    prodnovar[i] = proddeplist[i].Myprodno;
                    prodnamevar[i] = proddeplist[i].Myprodname;
                    prodsizevar[i] = proddeplist[i].Myprodsize;
                    lastaddvar[i] = proddeplist[i].Mylastadd;
                    retailpricevar[i] = proddeplist[i].Myretailprice;
                    belongtovar[i] = proddeplist[i].Mybelognto;
                    prodpervar[i] = proddeplist[i].Myysbl;

                }

             
                return "调用成功";

            }
            catch (FaultException<WCFServiceWrapper.WcfSvc.GetProddepinfoFault> ex)
            {
                System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
               
                return "调用失败";
            }
            catch (CommunicationException ex)
            {
                System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
             
                return "调用失败";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                 return "调用失败";
            }

        }

       public  string invokmyuploadgjd(string listnomainvar, string clinomainvar, DateTime localtimemainvar, int belongtomainvar, int nowstatusmainvar, string[] listnosubvar, string[] prodnosubvar, double[] neednumsubvar, int[] statusubvar, DateTime[] lesttimevar, string wcfaddr, string theusername, string thepw)
         {
             WCFServiceWrapper.Uploadthegjdmainstruct uploadgjdmainstruct = new WCFServiceWrapper.Uploadthegjdmainstruct();
                uploadgjdmainstruct.Mylistnomain=listnomainvar;
                 uploadgjdmainstruct.Myclinomain=clinomainvar;
                 uploadgjdmainstruct.Mylocaltimemain=localtimemainvar;
                 uploadgjdmainstruct.Mybelongtomain=belongtomainvar;
                 uploadgjdmainstruct.Mynowstatusmain = nowstatusmainvar;
                
                 int rocordcount = listnosubvar.Length;
                 int i=0;
                 WCFServiceWrapper.Uploadthegjdsubstruct[] uploadgjdsubstruct = new WCFServiceWrapper.Uploadthegjdsubstruct[rocordcount];
                 for (i = 0; i < rocordcount; i++)
                 {
                     uploadgjdsubstruct[i].Mylistnosub = listnosubvar[i];
                     uploadgjdsubstruct[i].Myprodnosub = prodnosubvar[i];
                     uploadgjdsubstruct[i].Myneednumsub = neednumsubvar[i];
                     uploadgjdsubstruct[i].Mystatusub = statusubvar[i];
                     uploadgjdsubstruct[i].Mylesttimesub = lesttimevar[i];

                 }

                 try
                 {
                     thepw = getthemd5string(thepw);
                     string resultstring = WCFServiceWrapper.SvcWrapper.invokmyuploadgjd(uploadgjdmainstruct, uploadgjdsubstruct, wcfaddr, theusername, thepw);
                     if (resultstring == "上传成功")
                     {
                         return "调用成功";
                     }
                     else
                     {
                         return "调用失败";
                     }
                 }
                 catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> ex)
                 {
                     System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
                     return "调用失败";
                 }
                 catch (CommunicationException ex)
                 {
                     System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                      return "调用失败";
                 }
                 catch (Exception ex)
                 {
                     System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                     return "调用失败";
                 }

                

         }

         public string invokgetinvmaininfo(DateTime begintimemain, DateTime endtimemain, string clinomain, int belongtomain, ref string[] listnomainvar, ref string[] clinomainvar, ref string[] clinamemainvar, ref DateTime[] invdatemainvar, ref double[] invmonmainvar, ref string[] invmemomainvar, string wcfaddr, string theusername, string thepw)
         {
             WCFServiceWrapper.MyInvMainStruct[] invmainstruct = new WCFServiceWrapper.MyInvMainStruct[500];
             try
             {
                 thepw = getthemd5string(thepw);
                 invmainstruct = WCFServiceWrapper.SvcWrapper.invokegetinvmaininfo(begintimemain, endtimemain, clinomain, belongtomain, wcfaddr, theusername, thepw);
                 int rowcount = invmainstruct.Length;
                 int i = 0;
                  listnomainvar=new string[rowcount];
                 clinomainvar=new string[rowcount];
                 clinamemainvar=new string[rowcount];
                 invdatemainvar=new DateTime[rowcount];
                 invmonmainvar=new double[rowcount];
                 invmemomainvar = new string[rowcount];

                 for (i = 0; i < rowcount; i++)
                 {
                     listnomainvar[i] = invmainstruct[i].Mylistnomain ;
                     clinomainvar[i] = invmainstruct[i].Myclinomain ;
                     clinamemainvar[i] = invmainstruct[i].Myclinamemain ;
                     invdatemainvar[i] = invmainstruct[i].Myinvdatemain ;
                     invmonmainvar[i] = invmainstruct[i].Myinvmonmain ;
                     invmemomainvar[i] = invmainstruct[i].Myinvmemomain ;
                 }

                 return "调用成功";

             }
             catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> ex)
             {
                 System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
                 
                 return "调用失败";
             }
             catch (CommunicationException ex)
             {
                 System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                
                 return "调用失败";
             }
             catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                 return "调用失败";
             }


         }


         public string invokgetinvsubinfo(string listnosubvar, int belongtosubvar, ref string[] invsubprodnovar, ref string[] invsubprodnamevar, ref string[] invsubprodsizevar, ref string[] invsubmonadvar, ref string[] invsubboxnumvar, ref string[] invsubwarenovar, ref string[] invsubprodaddvar, ref string[] invsubbatchnovar, ref double[] invsubinvnumvar, ref double[] invsubstdprice, ref double[] invsubsellpricevar, ref DateTime[] invsubavaildatevar, ref double[] invsubretailpricevar, ref string[] invsubprodmade, ref string[] invsubprodlabelvar, ref string[] invsubprodpzwhvar, ref string[] invsubboxmidnum, ref string[] invsubbarcode, string wcfaddr, string theusername, string thepw)
         {
             WCFServiceWrapper.MyInvSubStruct[] invsubstruct = new WCFServiceWrapper.MyInvSubStruct[500];
             try
             {
                 thepw = getthemd5string(thepw);
                 invsubstruct = WCFServiceWrapper.SvcWrapper.invokgetinvsubinfo(listnosubvar, belongtosubvar, wcfaddr, theusername, thepw);
                 int rowcount = invsubstruct.Length;
                 invsubprodnovar = new string[rowcount]; 
                 invsubprodnamevar = new string[rowcount]; 
                 invsubprodsizevar = new string[rowcount]; 
                 invsubmonadvar = new string[rowcount]; 
                 invsubboxnumvar = new string[rowcount]; 
                 invsubwarenovar = new string[rowcount]; 
                 invsubprodaddvar = new string[rowcount]; 
                 invsubbatchnovar = new string[rowcount]; 
                 invsubinvnumvar = new double[rowcount]; 
                 invsubstdprice = new double[rowcount]; 
                 invsubsellpricevar = new double[rowcount]; 
                 invsubavaildatevar = new DateTime[rowcount]; 
                 invsubretailpricevar = new double[rowcount]; 
                 invsubprodmade = new string[rowcount]; 
                 invsubprodlabelvar = new string[rowcount]; 
                 invsubprodpzwhvar = new string[rowcount]; 
                 invsubboxmidnum = new string[rowcount]; 
                 invsubbarcode = new string[rowcount];
                 int i = 0;

                 for (i = 0; i < rowcount; i++)
                 {
                   invsubprodnovar[i]=invsubstruct[i].Myinvsubprodno;
                 invsubprodnamevar[i]=invsubstruct[i].Myinvsubprodname; 
                 invsubprodsizevar[i]=invsubstruct[i].Myinvsubprodsize; 
                 invsubmonadvar[i]=invsubstruct[i].Myinvsubmonad; 
                 invsubboxnumvar[i]=invsubstruct[i].Myinvsubboxnum; 
                 invsubwarenovar[i]=invsubstruct[i].Myinvsubwareno; 
                 invsubprodaddvar[i]=invsubstruct[i].Myinvsubprodadd; 
                 invsubbatchnovar[i]=invsubstruct[i].Myinvsubbatchno; 
                 invsubinvnumvar[i]=invsubstruct[i].Myinvsubinvnum; 
                 invsubstdprice[i]=invsubstruct[i].Myinvsubstdprice; 
                 invsubsellpricevar[i]=invsubstruct[i].Myinvsubsellprice; 
                 invsubavaildatevar[i]=invsubstruct[i].Myinvsubavaildate;  
                 invsubretailpricevar[i]=invsubstruct[i].Myinvsubretailprice; 
                 invsubprodmade[i]=invsubstruct[i].Myinvsubprodmade; 
                 invsubprodlabelvar[i]=invsubstruct[i].Myinvsubprodlabel; 
                 invsubprodpzwhvar[i]=invsubstruct[i].Myinvsubprodpzwh; 
                 invsubboxmidnum[i]=invsubstruct[i].Myinvsubboxmidnum;
                 invsubbarcode[i] = invsubstruct[i].Myinvsubbarcode;
                 }
                 return "调用成功";


             }
             catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvSubInfoFault> ex)
             {
                 System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
               
                 return "调用失败";
             }
             catch (CommunicationException ex)
             {
                 System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                
                 return "调用失败";
             }
             catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                
                 return "调用失败";
             }
         }


       public   string invokclientinfo(ref string[] clientclinovar, ref string[] clientname, ref double[] clientsumjf, ref string[] clientadd, ref string[] clientclitelvar, ref string[] clientclimemo, ref string[] clientsex, string wcfaddr, string theusername, string thepw)
         {
             WCFServiceWrapper.MyClientInfostruct[] clientstruct = new WCFServiceWrapper.MyClientInfostruct[8000];
             try
             {
                 thepw = getthemd5string(thepw);
                 clientstruct = WCFServiceWrapper.SvcWrapper.invokclientinfo(wcfaddr, theusername, thepw);
                 int recodrdcount = clientstruct.Length;
                 int i = 0;

                     clientclinovar= new string[recodrdcount];
                     clientname = new string[recodrdcount];
                     clientsumjf =  new double[recodrdcount];
                     clientadd = new string[recodrdcount];
                     clientclitelvar= new string[recodrdcount];
                     clientclimemo = new string[recodrdcount];
                     clientsex = new string[recodrdcount];

                 for (i = 0; i < recodrdcount; i++)
                 {
                     clientclinovar[i] = clientstruct[i].Myclientclino;
                     clientname[i] = clientstruct[i].Myclientcliname;
                     clientsumjf[i] = clientstruct[i].Myclientsumjf;
                     clientadd[i] = clientstruct[i].Myclientcliadd;
                     clientclitelvar[i] = clientstruct[i].Myclientclitel;
                     clientclimemo[i] = clientstruct[i].Myclientclimemo;
                     clientsex[i] = clientstruct[i].Myclientsex;
                 }
                 return "调用成功";

             }
             catch (FaultException<WCFServiceWrapper.WcfSvc.GetClientInfoFault> ex)
             {
                 System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
                 
                 return "调用失败";
             }
             catch (CommunicationException ex)
             {
                 System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                 
                 return "调用失败";
             }
             catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
                 
                 return "调用失败";
             }


         }


       public string invokGetboxmidnum(ref string[] prodnovar, ref string[] prodnamevar, ref string[] boxmidnumvar, string wcfaddr, string theusername, string thepw)
       {
           WCFServiceWrapper.Myboxmediumstruct[] boxmedstruct = new WCFServiceWrapper.Myboxmediumstruct[8000];
           try
           {
               thepw = getthemd5string(thepw);
               boxmedstruct = WCFServiceWrapper.SvcWrapper.invokGetboxmidnum(wcfaddr, theusername, thepw);
               int recordcount = boxmedstruct.Length;
               int i = 0;

               prodnovar = new string[recordcount];
               prodnamevar = new string[recordcount];
               boxmidnumvar = new string[recordcount];

               for (i = 0; i < recordcount; i++)
               {
                   prodnovar[i] = boxmedstruct[i].Myprodno;
                   prodnamevar[i] = boxmedstruct[i].Myprodname;
                   boxmidnumvar[i] = boxmedstruct[i].Myboxmidnum;
               }
               return "调用成功";

           }
           catch (FaultException<WCFServiceWrapper.WcfSvc.BoxmidnumFault> ex)
           {
               System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
              
               return "调用失败";
           }
           catch (CommunicationException ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
             
               return "调用失败";
           }
           catch (Exception ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              
               return "调用失败";
           }

       }



       public string invokProdfull(ref string[] prodnovar, ref string[] prodnamevar, ref string[] prodsizevar, ref string[] monadvar, ref string[] lastaddvar, ref string[] barcodevar, ref string[] prodpzwhvar, ref double[] stdpricevar, ref double[] retailpricevar, ref string[] prodmadevar, ref string[] prodlabelvar, ref bool[] sellstopvar, string wcfaddr, string theusername, string thepw)
       {
           WCFServiceWrapper.MyProdfullStruct[] prodfullstruct = new WCFServiceWrapper.MyProdfullStruct[9000];
           try
           {
               thepw = getthemd5string(thepw);
               prodfullstruct = WCFServiceWrapper.SvcWrapper.invokProdfull(wcfaddr, theusername, thepw);
               int recordcount = prodfullstruct.Length;
               int i = 0;

                  prodnovar= new string[recordcount];
                   prodnamevar= new string[recordcount];
                   prodsizevar=new string[recordcount];
                   monadvar= new string[recordcount];
                   lastaddvar= new string[recordcount];
                   barcodevar= new string[recordcount];
                   prodpzwhvar= new string[recordcount];
                   stdpricevar= new double[recordcount];
                   retailpricevar= new double[recordcount];
                   prodmadevar= new string[recordcount];
                   prodlabelvar= new string[recordcount];
                   sellstopvar= new bool[recordcount];


               for (i = 0; i < recordcount; i++)
               {
                   prodnovar[i] = prodfullstruct[i].Myprodno;
                   prodnamevar[i] = prodfullstruct[i].Myprodname;
                   prodsizevar[i] = prodfullstruct[i].Myprodsize;
                   monadvar[i] = prodfullstruct[i].Mymonad;
                   lastaddvar[i] = prodfullstruct[i].Mylastadd;
                   barcodevar[i] = prodfullstruct[i].Mybarcode;
                   prodpzwhvar[i] = prodfullstruct[i].Myprodpzwh;
                   stdpricevar[i] = prodfullstruct[i].Mystdprice;
                   retailpricevar[i] = prodfullstruct[i].Myretailprice;
                   prodmadevar[i] = prodfullstruct[i].Myprodmade;
                   prodlabelvar[i] = prodfullstruct[i].Myprodlabel;
                   sellstopvar[i] = prodfullstruct[i].Mysellstop;
               }
               return "调用成功";
           }
           catch (FaultException<WCFServiceWrapper.WcfSvc.ProdfullFault> ex)
           {
               System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
               return "调用失败";
           }
           catch (CommunicationException ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
               return "调用失败";
           }
           catch (Exception ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
               return "调用失败";
           }
       }

      public string invokProdfullsingle(int mybleongto,ref string[] prodnovar, ref string[] prodnamevar, ref string[] prodsizevar, ref string[] monadvar, ref string[] lastaddvar, ref string[] barcodevar, ref string[] prodpzwhvar, ref double[] stdpricevar, ref double[] retailpricevar, ref string[] prodmadevar, ref string[] prodlabelvar, ref bool[] sellstopvar, string wcfaddr, string theusername, string thepw)
       {
           WCFServiceWrapper.MyProdfullStruct[] prodfullstruct = new WCFServiceWrapper.MyProdfullStruct[9000];
           try
           {
               thepw = getthemd5string(thepw);
               prodfullstruct = WCFServiceWrapper.SvcWrapper.invokProdfullsingle(mybleongto,wcfaddr, theusername, thepw);
               int recordcount = prodfullstruct.Length;
               int i = 0;

               prodnovar = new string[recordcount];
               prodnamevar = new string[recordcount];
               prodsizevar = new string[recordcount];
               monadvar = new string[recordcount];
               lastaddvar = new string[recordcount];
               barcodevar = new string[recordcount];
               prodpzwhvar = new string[recordcount];
               stdpricevar = new double[recordcount];
               retailpricevar = new double[recordcount];
               prodmadevar = new string[recordcount];
               prodlabelvar = new string[recordcount];
               sellstopvar = new bool[recordcount];


               for (i = 0; i < recordcount; i++)
               {
                   prodnovar[i] = prodfullstruct[i].Myprodno;
                   prodnamevar[i] = prodfullstruct[i].Myprodname;
                   prodsizevar[i] = prodfullstruct[i].Myprodsize;
                   monadvar[i] = prodfullstruct[i].Mymonad;
                   lastaddvar[i] = prodfullstruct[i].Mylastadd;
                   barcodevar[i] = prodfullstruct[i].Mybarcode;
                   prodpzwhvar[i] = prodfullstruct[i].Myprodpzwh;
                   stdpricevar[i] = prodfullstruct[i].Mystdprice;
                   retailpricevar[i] = prodfullstruct[i].Myretailprice;
                   prodmadevar[i] = prodfullstruct[i].Myprodmade;
                   prodlabelvar[i] = prodfullstruct[i].Myprodlabel;
                   sellstopvar[i] = prodfullstruct[i].Mysellstop;
               }
               return "调用成功";
           }
           catch (FaultException<WCFServiceWrapper.WcfSvc.ProdfullFault> ex)
           {
               System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
               return "调用失败";
           }
           catch (CommunicationException ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
               return "调用失败";
           }
           catch (Exception ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
               return "调用失败";
           }
       }


       public string invokGetProdrecip(ref string[] prodnovar, ref string[] prodnamevar, ref bool[] recipevar, string wcfaddr, string theusername, string thepw)
       {
           WCFServiceWrapper.MyProdrecipeStruct[] prodrecipestruct=new WCFServiceWrapper.MyProdrecipeStruct[9000];
           try
           {
               thepw = getthemd5string(thepw);
               prodrecipestruct = WCFServiceWrapper.SvcWrapper.invokGetProdrecip(wcfaddr, theusername, thepw);
               int recordcount = prodrecipestruct.Length;
               int i = 0;
               prodnovar=new string[recordcount];
               prodnamevar = new string[recordcount];
               recipevar = new bool[recordcount];

               for (i = 0; i < recordcount; i++)
               {
                   prodnovar[i] = prodrecipestruct[i].Myprodno;
                   prodnamevar[i] = prodrecipestruct[i].Myprodname;
                   recipevar[i] = prodrecipestruct[i].Myrecipe; 
               }

               return "调用成功";
               

           }
            catch (FaultException<WCFServiceWrapper.WcfSvc.ProdrecipeFault> ex)
           {
               System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
             
               return "调用失败";
           }
           catch (CommunicationException ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
             
               return "调用失败";
           }
           catch (Exception ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
          
               return "调用失败";
           }
       }

       public string invokSimilarProdname(ref string[] prodnofir, ref string[] prodnamefir, ref string[] prodsizefir, ref string[] monadfir, ref bool[] llstopfir, ref string[] lastaddfir, ref string[] prodnasecfir, ref double[] depnumfir, ref  string[] belongfir, ref double[] buypricefir, ref string[] prodnosec, ref string[] prodnamesec, ref string[] prodsizesec, ref string[] monadsec, ref bool[] llstopsec, ref string[] lastaddsec, ref string[] prodnasecsec, ref double[] depnumsec, ref  string[] belongsec, ref double[] buypricesec, string wcfaddr, string theusername, string thepw)
       {
           WCFServiceWrapper.SimilarProdnamestruct[] simlarnamestruct = new WCFServiceWrapper.SimilarProdnamestruct[5000];
           try
           {
               thepw = getthemd5string(thepw);
               simlarnamestruct = WCFServiceWrapper.SvcWrapper.invokSimilarProdname(wcfaddr, theusername, thepw);
               int recordcount = simlarnamestruct.Length;
               int i = 0;
               prodnofir = new string[recordcount];
               prodnamefir = new string[recordcount];
               prodsizefir = new string[recordcount];
               monadfir = new string[recordcount];
               llstopfir = new bool[recordcount];
               lastaddfir = new string[recordcount];
               prodnasecfir = new string[recordcount];
               depnumfir = new double[recordcount];
               belongfir = new string[recordcount];
               buypricefir = new double[recordcount];
               prodnosec = new string[recordcount];
               prodnamesec = new string[recordcount];
               prodsizesec = new string[recordcount];
               monadsec = new string[recordcount];
               llstopsec = new bool[recordcount];
               lastaddsec = new string[recordcount];
               prodnasecsec = new string[recordcount];
               depnumsec = new double[recordcount];
               belongsec = new string[recordcount];
               buypricesec = new double[recordcount];

               for (i = 0; i < recordcount; i++)
               {
                   prodnofir[i] = simlarnamestruct[i].Myprodnofir;
                   prodnamefir[i] = simlarnamestruct[i].Myprodnamefir;
                   prodsizefir[i] = simlarnamestruct[i].Myprodsizefir;
                   monadfir[i] = simlarnamestruct[i].Mymonadfir;
                   llstopfir[i] = simlarnamestruct[i].Mysellstopfir;
                   lastaddfir[i] = simlarnamestruct[i].Mylastaddfir;
                   prodnasecfir[i] = simlarnamestruct[i].Myprodnasecfir;
                   depnumfir[i] = simlarnamestruct[i].Mydepnumfir;
                   belongfir[i] = simlarnamestruct[i].Mybelongfir;
                   buypricefir[i] = simlarnamestruct[i].Mybuypricefir;
                   prodnosec[i] = simlarnamestruct[i].Myprodnosec;
                   prodnamesec[i] = simlarnamestruct[i].Myprodnamesec;
                   prodsizesec[i] = simlarnamestruct[i].Myprodsizesec;
                   monadsec[i] = simlarnamestruct[i].Mymonadsec;
                   llstopsec[i] = simlarnamestruct[i].Mysellstopsec;
                   lastaddsec[i] = simlarnamestruct[i].Mylastaddsec;
                   prodnasecsec[i] = simlarnamestruct[i].Myprodnasecsec;
                   depnumsec[i] = simlarnamestruct[i].Mydepnumsec;
                   belongsec[i] = simlarnamestruct[i].Mybelongsec;
                   buypricesec[i] = simlarnamestruct[i].Mybuypricesec;
               }

               return "调用成功";

           }
           catch (FaultException<WCFServiceWrapper.WcfSvc.SimilarProdnameFault> ex)
           {
               System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);
             
               return "调用失败";
           }
           catch (CommunicationException ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              
               return "调用失败";
           }
           catch (Exception ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              
               return "调用失败";
           }
       }


      public string invokgetservertime(ref DateTime myservertime, string wcfaddr, string theusername, string thepw)
       {
           try
           {
              thepw = getthemd5string(thepw);
              myservertime=WCFServiceWrapper.SvcWrapper.invokegetime(wcfaddr, theusername, thepw);
              return "调用成功";
           }
           catch (CommunicationException ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());

               return "调用失败";
           }
           catch (Exception ex)
           {
               System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());

               return "调用失败";
           }
       }

      public double calthesimarlar(string strtargetone, string strtargetwo)
      {
          LevenshteinDistance ldistance=new LevenshteinDistance();
          double resultper = ldistance.LevenshteinDistancePercent(strtargetone, strtargetwo);
          return resultper;
      }

      public string getthemd5string(string theinputstring)
      {
          if (theinputstring==null)
          throw new Exception("发生错误：传入的是空值");

          myMD5hash themd5class = new myMD5hash();
          string resultstring = themd5class.getMd5Hash(theinputstring);
          return resultstring;
      }


      public string gettheupdate(string webaddr)
      {
          try
          {
              XmlTextReader reader = new XmlTextReader(webaddr);
              string mybhver = null;
              while (reader.Read())
              {
                  if (reader.NodeType == XmlNodeType.Element)
                  {
                      string elementName = reader.Name;

                      if (elementName == "Version")
                      {
                          mybhver = reader["num"];
                      }


                  }

              }
              return mybhver;

          }

          catch 
          {
              return "nothing";
          }


      }

      public string invokclientinfover2(ref string[] clientclinovar, ref string[] clientname, ref double[] clientsumjf, ref string[] clientadd, ref string[] clientclitelvar, ref string[] clientclimemo, ref string[] clientsex, ref string[] cliass, ref double[] cliper, ref string[] clienttypeno, ref int[] jf, ref int[] nl, ref int[] prjf, string wcfaddr, string theusername, string thepw)
      {
          WCFServiceWrapper.MyClientInfostruct[] clientstruct = new WCFServiceWrapper.MyClientInfostruct[8000];
          try
          {
              thepw = getthemd5string(thepw);
              clientstruct = WCFServiceWrapper.SvcWrapper.invokclientinfo(wcfaddr, theusername, thepw);
              int recodrdcount = clientstruct.Length;
              int i = 0;

              clientclinovar = new string[recodrdcount];
              clientname = new string[recodrdcount];
              clientsumjf = new double[recodrdcount];
              clientadd = new string[recodrdcount];
              clientclitelvar = new string[recodrdcount];
              clientclimemo = new string[recodrdcount];
              clientsex = new string[recodrdcount];
              cliass= new string[recodrdcount];
              cliper = new double[recodrdcount];
              clienttypeno = new string[recodrdcount];
              jf = new int[recodrdcount];
              nl = new int[recodrdcount];
              prjf = new int[recodrdcount];

              for (i = 0; i < recodrdcount; i++)
              {
                  clientclinovar[i] = clientstruct[i].Myclientclino;
                  clientname[i] = clientstruct[i].Myclientcliname;
                  clientsumjf[i] = clientstruct[i].Myclientsumjf;
                  clientadd[i] = clientstruct[i].Myclientcliadd;
                  clientclitelvar[i] = clientstruct[i].Myclientclitel;
                  clientclimemo[i] = clientstruct[i].Myclientclimemo;
                  clientsex[i] = clientstruct[i].Myclientsex;
                  cliass[i] = clientstruct[i].Mycliass;
                  cliper[i] = clientstruct[i].Mycliper;
                  clienttypeno[i] = clientstruct[i].Myclienttypeno;
                  jf[i] = clientstruct[i].Myjf;
                  nl[i] = clientstruct[i].Mynl;
                  prjf[i] = clientstruct[i].Myprjf;
              }
              return "调用成功";

          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetClientInfoFault> ex)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);

              return "调用失败";
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());

              return "调用失败";
          }
          catch (Exception ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());

              return "调用失败";
          }


      }

      public int invokeuploadfiveprod(string[] listnovar, DateTime[] invdatevar, string[] prodnovar, string[] prodnamevar, string[] prodaddvar, string[] batchnovar, double[] invnumvar, double[] stdpricevar, double[] sellpricevar, string[] clinovar, string[] invbywhovar, string[] mdnovar, string wcfaddr, string theusername, string thepw)
      {
          int recountcount = listnovar.Length;
          WCFServiceWrapper.Uploadfiveprodstr[] uploadstr = new WCFServiceWrapper.Uploadfiveprodstr[recountcount];
          for (int i = 0; i < recountcount; i++)
          {
              uploadstr[i].Mylistno = listnovar[i];
              uploadstr[i].Myinvdate = invdatevar[i];
              uploadstr[i].Myprodno = prodnovar[i];
              uploadstr[i].Myprodname = prodnamevar[i];
              uploadstr[i].Myprodadd = prodaddvar[i];
              uploadstr[i].Mybatchno = batchnovar[i];
              uploadstr[i].Myinvnum = invnumvar[i];
              uploadstr[i].Mystdprice = stdpricevar[i];
              uploadstr[i].Mysellprice = sellpricevar[i];
              uploadstr[i].Myclino = clinovar[i];
              uploadstr[i].Myinvbywho = invbywhovar[i];
              uploadstr[i].Mymdno = mdnovar[i];
          }
         
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.invokeuploadfiveprod(uploadstr, wcfaddr, theusername, thepw);
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.uploadfiveprodFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
             return -3;
          }
          
      }
      public int invokemyuploadgjdver2(string listnomain, string clinomain, string clinozymain, DateTime localtimemain, int nowstatusmain, string[] listnosub, string[] prodnosub, string[] prodnamesub, string[] lastaddsub, double[] neednumsub, int[] statusub, DateTime[] lesttimesub, ref string[] gjdnolack, ref string[] prodnolack, ref int[] reasonlack, string wcfaddr, string theusername, string thepw)
      {
          WCFServiceWrapper.Uploadthegjdmaindcver2struct upgjdmainstr = new WCFServiceWrapper.Uploadthegjdmaindcver2struct();
          upgjdmainstr.Mylistnomain = listnomain;
          upgjdmainstr.Myclinomain = clinomain;
          upgjdmainstr.Myclinozymain = clinozymain;
          upgjdmainstr.Mylocaltimemain = localtimemain;
          upgjdmainstr.Mynowstatusmain = nowstatusmain;
          int recountcount = listnosub.Length;
          WCFServiceWrapper.Uploadthegjdsubver2struct[] upgjdsubstr = new WCFServiceWrapper.Uploadthegjdsubver2struct[recountcount];
          for (int i = 0; i < recountcount; i++)
          {
              upgjdsubstr[i].Mylistnosub = listnosub[i];
              upgjdsubstr[i].Myprodnosub = prodnosub[i];
              upgjdsubstr[i].Myprodnamesub = prodnamesub[i];
              upgjdsubstr[i].Mylastaddsub = lastaddsub[i];
              upgjdsubstr[i].Myneednumsub = neednumsub[i];
              upgjdsubstr[i].Mystatusub = statusub[i];
              upgjdsubstr[i].Mylesttimesub = lesttimesub[i];
              upgjdsubstr[i].Myreason = 0;
              upgjdsubstr[i].Mybelong = 0;
          }
          WCFServiceWrapper.LackofGoodstruct[] lackgoodstr = new WCFServiceWrapper.LackofGoodstruct[0];
          int result;
          try
          {
              thepw = getthemd5string(thepw);
              result = WCFServiceWrapper.SvcWrapper.invokeupgjdver2(upgjdmainstr, upgjdsubstr, ref lackgoodstr, wcfaddr, theusername, thepw);
              int lackgoodcount = lackgoodstr.Length;
              gjdnolack = new string[lackgoodcount];
              prodnolack = new string[lackgoodcount];
              reasonlack = new int[lackgoodcount];
              for (int i = 0; i < lackgoodcount; i++)
              {
                  gjdnolack[i] = lackgoodstr[i].Mygjdno;
                  prodnolack[i] = lackgoodstr[i].Myprodno;
                  reasonlack[i] = lackgoodstr[i].lackreason;
              }
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return  -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return  -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
         
      }
      public int invokecheckkcbelong(string[] prodno, string[] prodname, string[] lastadd, string[] monad, ref string[] prodnoret, ref int[] belongtoret, string cli_no, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Checkkcretbelongstruct[] checkretstr = new WCFServiceWrapper.Checkkcretbelongstruct[recordcount];
          WCFServiceWrapper.Prodbelongtostruct[] prodbegstr = new WCFServiceWrapper.Prodbelongtostruct[recordcount];
          for (int i = 0; i < recordcount; i++)
          {
              checkretstr[i].Myprodno = prodno[i];
              checkretstr[i].Myprodname = prodname[i];
              checkretstr[i].Mylastadd = lastadd[i];
              checkretstr[i].Mymonad = monad[i];
          }
          
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.invokeCheckkcbelong(checkretstr, cli_no, ref prodbegstr, wcfaddr, theusername, thepw);
              int therecordcount = prodbegstr.Length;
              prodnoret = new string[therecordcount];
              belongtoret = new int[therecordcount];
              for (int i = 0; i < therecordcount; i++)
              {
                  prodnoret[i] = prodbegstr[i].Myprodno;
                  belongtoret[i] = prodbegstr[i].Mybelongto;
              }
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return  -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
         
      }
      public int invokeUploadthekc(string listnomain, string clinomain, string clinozymain, int nowstatusmain, string[] lnumno, string[] prodno, double[] stdprice, double[] invnum, DateTime[] depdate, double[] lestnum, double[] lnum, int[] theblongto, string wcfaddr, string theusername, string thepw)
      {
          WCFServiceWrapper.Uploadkcmainstruct upkcmainstr = new WCFServiceWrapper.Uploadkcmainstruct
          {
              Mylistnomain = listnomain,
              Myclinomain = clinomain,
              Myclinozymain = clinozymain,
              Mynowstatusmain = nowstatusmain
          };
          int recordcount = lnumno.Length;
          WCFServiceWrapper.Uploadkcsubstruct[] upldkcstr = new WCFServiceWrapper.Uploadkcsubstruct[recordcount];
          for (int i = 0; i < recordcount; i++)
          {
              upldkcstr[i].Mylnumno = lnumno[i];
              upldkcstr[i].Myprodno = prodno[i];
              upldkcstr[i].Mystdprice = stdprice[i];
              upldkcstr[i].Myinvnum = invnum[i];
              upldkcstr[i].Mydepdate = depdate[i];
              upldkcstr[i].Mylestnum = lestnum[i];
              upldkcstr[i].Mylnum = lnum[i];
              upldkcstr[i].theblongto = theblongto[i];
          }
        
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.invokeUploadthekc(upkcmainstr, upldkcstr, wcfaddr, theusername, thepw);
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
         
      }
      public int invokecheckretbelong(string[] prodno, string[] prodname, string[] lastadd, string[] batchno, string[] monad, ref string[] prodnoret, ref string[] batchnoret, ref int[] belongtoret, string cli_no, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Checkkcretbelongstruct[] checkblstr = new WCFServiceWrapper.Checkkcretbelongstruct[recordcount];
          WCFServiceWrapper.Prodbelongtostruct[] prodblstr = new WCFServiceWrapper.Prodbelongtostruct[recordcount];
          for (int i = 0; i < recordcount; i++)
          {
              checkblstr[i].Myprodno = prodno[i];
              checkblstr[i].Myprodname = prodname[i];
              checkblstr[i].Mylastadd = lastadd[i];
              checkblstr[i].Mybatchno = batchno[i];
          }
          
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.invokeCheckretbelg(checkblstr, cli_no, ref prodblstr, wcfaddr, theusername, thepw);
              int therecordcount = prodblstr.Length;
              prodnoret = new string[therecordcount];
              batchnoret = new string[therecordcount];
              belongtoret = new int[therecordcount];
              for (int i = 0; i < therecordcount; i++)
              {
                  prodnoret[i] = prodblstr[i].Myprodno;
                  batchnoret[i] = prodblstr[i].Mybatchno;
                  belongtoret[i] = prodblstr[i].Mybelongto;
              }
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return  -3;
          }
          
      }
      public int invokeUploadtheret(string listnomain, string clinomain, string clinozymain, int nowstatusmain, string[] lnumno, string[] prodno, string[] prodadd, string[] batchno, double[] retnum, double[] buyprice, double[] stdprice, int[] belongto, string wcfaddr, string theusername, string thepw)
      {
          WCFServiceWrapper.Uploadkcmainstruct upretmainstr = new WCFServiceWrapper.Uploadkcmainstruct
          {
              Mylistnomain = listnomain,
              Myclinomain = clinomain,
              Myclinozymain = clinozymain,
              Mynowstatusmain = nowstatusmain
          };
          int recordcount = lnumno.Length;
          WCFServiceWrapper.Uploadret2substruct[] upretstr = new WCFServiceWrapper.Uploadret2substruct[recordcount];
          for (int i = 0; i < recordcount; i++)
          {
              upretstr[i].Mylnumno = lnumno[i];
              upretstr[i].Myprodno = prodno[i];
              upretstr[i].Myprodadd = prodadd[i];
              upretstr[i].Mybatchno = batchno[i];
              upretstr[i].Myretnum = retnum[i];
              upretstr[i].Mybuyprice = buyprice[i];
              upretstr[i].Mystdprice = stdprice[i];
              upretstr[i].theblongto = belongto[i];
          }
          int result;
          try
          {
              thepw = getthemd5string(thepw);
              result = WCFServiceWrapper.SvcWrapper.invokeUploadret(upretmainstr, upretstr, wcfaddr, theusername, thepw);
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
        
      }
      public int getheautodepbz(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref int[] bz, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Bzkstruct[] bzstr = new WCFServiceWrapper.Bzkstruct[recordcount];
         
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Gettheautodep(ref bzstr, wcfaddr, theusername, thepw);
              int therecordcount = bzstr.Length;
              prodno = new string[therecordcount];
              prodnanme = new string[therecordcount];
              lastadd = new string[therecordcount];
              bz = new int[therecordcount];
              for (int i = 0; i < therecordcount; i++)
              {
                  prodno[i] = bzstr[i].Myprodno;
                  prodnanme[i] = bzstr[i].Myprodnanme;
                  lastadd[i] = bzstr[i].Mylastadd;
                  bz[i] = bzstr[i].Mybz;
              }
              return result ;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
          
      }
      public int getheprodbth(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref string[] bz, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Strkstruct[] strkstr = new WCFServiceWrapper.Strkstruct[recordcount];
          
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Getthebth(ref strkstr, wcfaddr, theusername, thepw);
              int therecordcount = strkstr.Length;
              prodno = new string[therecordcount];
              prodnanme = new string[therecordcount];
              lastadd = new string[therecordcount];
              bz = new string[therecordcount];
              for (int i = 0; i < therecordcount; i++)
              {
                  prodno[i] = strkstr[i].Myprodno;
                  prodnanme[i] = strkstr[i].Myprodnanme;
                  lastadd[i] = strkstr[i].Mylastadd;
                  bz[i] = strkstr[i].Mystr;
              }
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return - 2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
          
      }
      public int getheoldgf(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref string[] gf, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Strkstruct[] strkstr = new WCFServiceWrapper.Strkstruct[recordcount];
         
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Gettheoldgf(ref strkstr, wcfaddr, theusername, thepw);
              int therecordcount = strkstr.Length;
              prodno = new string[therecordcount];
              prodnanme = new string[therecordcount];
              lastadd = new string[therecordcount];
              gf = new string[therecordcount];
              for (int i = 0; i < therecordcount; i++)
              {
                  prodno[i] = strkstr[i].Myprodno;
                  prodnanme[i] = strkstr[i].Myprodnanme;
                  lastadd[i] = strkstr[i].Mylastadd;
                  gf[i] = strkstr[i].Mystr;
              }
              return result ;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
         
      }

      public int getheoldgfsingle(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref string[] gf, int thedb,string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Strkstruct[] strkstr = new WCFServiceWrapper.Strkstruct[recordcount];

          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Gettheoldgfsingle(ref strkstr,thedb, wcfaddr, theusername, thepw);
              int therecordcount = strkstr.Length;
              prodno = new string[therecordcount];
              prodnanme = new string[therecordcount];
              lastadd = new string[therecordcount];
              gf = new string[therecordcount];
              for (int i = 0; i < therecordcount; i++)
              {
                  prodno[i] = strkstr[i].Myprodno;
                  prodnanme[i] = strkstr[i].Myprodnanme;
                  lastadd[i] = strkstr[i].Mylastadd;
                  gf[i] = strkstr[i].Mystr;
              }
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }

      }



      public int gethenewgf(ref string[] prodno, ref string[] prodnanme, ref string[] lastadd, ref double[] gf, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Dblkstruct[] dblkstr = new WCFServiceWrapper.Dblkstruct[recordcount];
          
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Getthenewgf(ref dblkstr, wcfaddr, theusername, thepw);
              int therecordcount = dblkstr.Length;
              prodno = new string[therecordcount];
              prodnanme = new string[therecordcount];
              lastadd = new string[therecordcount];
              gf = new double[therecordcount];
              for (int i = 0; i < therecordcount; i++)
              {
                  prodno[i] = dblkstr[i].Myprodno;
                  prodnanme[i] = dblkstr[i].Myprodnanme;
                  lastadd[i] = dblkstr[i].Mylastadd;
                  gf[i] = dblkstr[i].Mydbl;
              }
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
          
      }
      public int uploaddep(string[] prodno, string[] prodname, string[] prodadd, string[] batchno, double[] lestnum, string[] boxnum, DateTime[] availdate, double[] stdprice, string clino, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Depdc[] depdstr = new WCFServiceWrapper.Depdc[recordcount];
          for (int i = 0; i < recordcount; i++)
          {
              depdstr[i].Myprodno = prodno[i];
              depdstr[i].Myprodname = prodname[i];
              depdstr[i].Myprodadd = prodadd[i];
              depdstr[i].Mybatchno = batchno[i];
              depdstr[i].Mylestnum = lestnum[i];
              depdstr[i].Myboxnum = boxnum[i];
              depdstr[i].Myavaildate = availdate[i];
              depdstr[i].Mystdprice = stdprice[i];
          }
         
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Uploaddep(depdstr, clino, wcfaddr, theusername, thepw);
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
          
      }
      public int uploadchgprice(DateTime[] changedate, string[] prodno, string[] prodname, string[] prodsize, string[] prodadd, string[] batchno, string[] monad, double[] lestnum, double[] oldstdprice, double[] newstdprice, string clino, int softwaretype, string wcfaddr, string theusername, string thepw)
      {
          int recordcount = prodno.Length;
          WCFServiceWrapper.Changepricestr[] chgprstr = new WCFServiceWrapper.Changepricestr[recordcount];
          for (int i = 0; i < recordcount; i++)
          {
              chgprstr[i].changedate = changedate[i];
              chgprstr[i].prodno = prodno[i];
              chgprstr[i].prodname = prodname[i];
              chgprstr[i].prodsize = prodsize[i];
              chgprstr[i].prodadd = prodadd[i];
              chgprstr[i].batchno = batchno[i];
              chgprstr[i].monad = monad[i];
              chgprstr[i].lestnum = lestnum[i];
              chgprstr[i].old_std_price = oldstdprice[i];
              chgprstr[i].new_std_price = newstdprice[i];
          }
          
          try
          {
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Uploadchgprice(chgprstr, clino, softwaretype, wcfaddr, theusername, thepw);
              return result;
          }
          catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvMaininfoFault> faultException)
          {
              System.Windows.Forms.MessageBox.Show("发生错误：" + faultException.Detail.Operation + " 错误原因是：" + faultException.Detail.ProblemType);
              return -1;
          }
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
          
      }

    public  int getinvfull(DateTime begtime, DateTime endtime, string cli_no, int thebelong, int pageSize, int pageIndex, ref string counts,ref string pagecounts,ref string[] listno, ref  DateTime[] invdate, ref  string[] prodno, ref  string[] prodname, ref  string[] prodsize, ref  string[] prodadd, ref  string[] monad, ref  string[] batchno, ref  DateTime[] availdate, ref  double[] invnum, ref  double[] sellprice, ref  double[] retailprice, ref  string[] prodpzwh, string wcfaddr, string theusername, string thepw)
     {
         
          WCFServiceWrapper.querypostinfo theqr=new WCFServiceWrapper.querypostinfo();
          
              theqr.begtime =begtime ;
              theqr.endtime =endtime ;
              theqr.cli_no=cli_no ;
              theqr.thebelong=thebelong ;
              theqr.pageIndex =pageIndex;
              theqr.pageSize =pageSize ;
              WCFServiceWrapper.Invfullinfostr[] invsf = new WCFServiceWrapper.Invfullinfostr[1000];
            
        try
          {
            
              thepw = getthemd5string(thepw);
              int result = WCFServiceWrapper.SvcWrapper.Getinvinfo(ref invsf, ref counts, ref pagecounts, theqr, wcfaddr, theusername, thepw);
              int therecordcount = invsf.Length;
               listno=new string[therecordcount] ;
               invdate = new DateTime[therecordcount];   
               prodno=new string[therecordcount] ;   
                prodname=new string[therecordcount] ;   
                  prodsize=new string[therecordcount] ;   
                   prodadd=new string[therecordcount] ;  
                  monad=new string[therecordcount] ;   
                   batchno=new string[therecordcount] ;   
                   availdate=new DateTime[therecordcount] ;   
                invnum=new double[therecordcount] ;   
               sellprice=new double[therecordcount] ;   
                 retailprice=new double[therecordcount] ;   
               prodpzwh=new string[therecordcount] ;
               for (int i = 0; i < therecordcount; i++)
               {
                   listno[i]=invsf[i].listno;
                   invdate[i] = invsf[i].invdate;
                   prodno[i] = invsf[i].prodno;
                   prodname[i] = invsf[i].prodname;
                   prodsize[i] = invsf[i].prodsize;
                   prodadd[i] = invsf[i].prodadd;
                   monad[i] = invsf[i].monad;
                   batchno[i] = invsf[i].batchno;
                   availdate[i] = invsf[i].availdate;
                   invnum[i] = invsf[i].invnum;
                   sellprice[i] = invsf[i].sellprice;
                   retailprice[i] = invsf[i].retailprice;
                   availdate[i] = invsf[i].availdate;
                   prodpzwh[i] = invsf[i].prodpzwh;
               }

              
               return result;
          }
        
          catch (CommunicationException ex)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
              return -2;
          }
          catch (Exception ex2)
          {
              System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
              return -3;
          }
          

          
          
          


     }


    public int getdepinfo( int thebelong, ref  string[] prodno, ref  string[] prodname, ref  string[] prodsize, ref  string[] monad, ref  string[] batchno, ref  string[] prodadd, ref  double[] lestnum, ref  DateTime[] availdate, string wcfaddr, string theusername, string thepw)
  {
      WCFServiceWrapper.lestmodelstr[] prodep = new WCFServiceWrapper.lestmodelstr[1000];
      try
      {
          thepw = getthemd5string(thepw);
          
          int result = WCFServiceWrapper.SvcWrapper.Getdepfullinfo(ref prodep, thebelong, wcfaddr, theusername, thepw);
          int thecount = prodep.Length;
          prodno=new string[thecount];
          prodname=new string[thecount];
          prodsize=new string[thecount]; 
          monad=new string[thecount]; 
          batchno=new string[thecount];
          prodadd=new string[thecount];
          lestnum=new double [thecount];
          availdate = new DateTime[thecount];
          for (int i = 0; i < thecount; i++)
          {
              prodno[i] = prodep[i].prodno ;
              prodname[i] = prodep[i].prodname;
              prodsize[i] = prodep[i].prodsize;
              monad[i] = prodep[i].monad;
              batchno[i] = prodep[i].batchno;
              prodadd[i] = prodep[i].prodadd;
              lestnum[i] = prodep[i].lestnum;
              availdate[i] = prodep[i].availdate; 

          }
          return result;
      }
      catch (CommunicationException ex)
      {
          System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());
          return -2;
      }
      catch (Exception ex2)
      {
          System.Windows.Forms.MessageBox.Show("错误发生：" + ex2.ToString());
          return -3;
      }
          

   }

   public string invokgetinvsubinfo2(string listnosubvar, int belongtosubvar, ref string[] invsubprodnovar, ref string[] invsubprodnamevar, ref string[] invsubprodsizevar, ref string[] invsubmonadvar, ref string[] invsubboxnumvar, ref string[] invsubwarenovar, ref string[] invsubprodaddvar, ref string[] invsubbatchnovar, ref double[] invsubinvnumvar, ref double[] invsubstdprice, ref double[] invsubsellpricevar, ref DateTime[] invsubavaildatevar, ref double[] invsubretailpricevar, ref string[] invsubprodmade, ref string[] invsubprodlabelvar, ref string[] invsubprodpzwhvar, ref string[] invsubboxmidnum, ref string[] invsubbarcode,ref DateTime[] invsubproducedate, string wcfaddr, string theusername, string thepw)
   {
        WCFServiceWrapper.MyInvSubStruct2[] invsubstruct = new WCFServiceWrapper.MyInvSubStruct2[500];
        try
        {
            thepw = getthemd5string(thepw);
            invsubstruct = WCFServiceWrapper.SvcWrapper.invokgetinvsubinfo2(listnosubvar, belongtosubvar, wcfaddr, theusername, thepw);
            int rowcount = invsubstruct.Length;
            invsubprodnovar = new string[rowcount];
            invsubprodnamevar = new string[rowcount];
            invsubprodsizevar = new string[rowcount];
            invsubmonadvar = new string[rowcount];
            invsubboxnumvar = new string[rowcount];
            invsubwarenovar = new string[rowcount];
            invsubprodaddvar = new string[rowcount];
            invsubbatchnovar = new string[rowcount];
            invsubinvnumvar = new double[rowcount];
            invsubstdprice = new double[rowcount];
            invsubsellpricevar = new double[rowcount];
            invsubavaildatevar = new DateTime[rowcount];
            invsubretailpricevar = new double[rowcount];
            invsubprodmade = new string[rowcount];
            invsubprodlabelvar = new string[rowcount];
            invsubprodpzwhvar = new string[rowcount];
            invsubboxmidnum = new string[rowcount];
            invsubbarcode = new string[rowcount];
            invsubproducedate = new DateTime[rowcount];
            int i = 0;

            for (i = 0; i < rowcount; i++)
            {
                invsubprodnovar[i] = invsubstruct[i].Myinvsubprodno;
                invsubprodnamevar[i] = invsubstruct[i].Myinvsubprodname;
                invsubprodsizevar[i] = invsubstruct[i].Myinvsubprodsize;
                invsubmonadvar[i] = invsubstruct[i].Myinvsubmonad;
                invsubboxnumvar[i] = invsubstruct[i].Myinvsubboxnum;
                invsubwarenovar[i] = invsubstruct[i].Myinvsubwareno;
                invsubprodaddvar[i] = invsubstruct[i].Myinvsubprodadd;
                invsubbatchnovar[i] = invsubstruct[i].Myinvsubbatchno;
                invsubinvnumvar[i] = invsubstruct[i].Myinvsubinvnum;
                invsubstdprice[i] = invsubstruct[i].Myinvsubstdprice;
                invsubsellpricevar[i] = invsubstruct[i].Myinvsubsellprice;
                invsubavaildatevar[i] = invsubstruct[i].Myinvsubavaildate;
                invsubretailpricevar[i] = invsubstruct[i].Myinvsubretailprice;
                invsubprodmade[i] = invsubstruct[i].Myinvsubprodmade;
                invsubprodlabelvar[i] = invsubstruct[i].Myinvsubprodlabel;
                invsubprodpzwhvar[i] = invsubstruct[i].Myinvsubprodpzwh;
                invsubboxmidnum[i] = invsubstruct[i].Myinvsubboxmidnum;
                invsubbarcode[i] = invsubstruct[i].Myinvsubbarcode;
                invsubproducedate[i] = invsubstruct[i].Myproducedate;
            }
            return "调用成功";


        }
        catch (FaultException<WCFServiceWrapper.WcfSvc.GetInvSubInfoFault> ex)
        {
            System.Windows.Forms.MessageBox.Show("发生错误：" + ex.Detail.Operation + " 错误原因是：" + ex.Detail.ProblemType);

            return "调用失败";
        }
        catch (CommunicationException ex)
        {
            System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());

            return "调用失败";
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("错误发生：" + ex.ToString());

            return "调用失败";
        }
    }


}

        
}
