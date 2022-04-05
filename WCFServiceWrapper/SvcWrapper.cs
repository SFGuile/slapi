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
using System.ServiceModel.Description;
using System.Diagnostics;


namespace WCFServiceWrapper
{
    public static partial class SvcWrapper
    {
        public static Proddepinfostruct[] invokgetproddep(string wcfaddr, string theusername, string thepw)
        {

            WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);

           
           
            WcfSvc.ProddepinfoList myproddeplist = new WcfSvc.ProddepinfoList();
            
            try
            {
                myproddeplist= m_proxy.GetProddepinfo();
                m_proxy.Close();
                int recordcount=0;
                int i=0;
                recordcount=myproddeplist.Count;
                Proddepinfostruct[] proddepstruct=new Proddepinfostruct[recordcount];

                 foreach (WcfSvc.Proddepinfo myproddepdc in myproddeplist)
                {
                    proddepstruct[i].Myprodno  = myproddepdc.Myprodno;
                    proddepstruct[i].Myprodname  = myproddepdc.Myprodname;
                    proddepstruct[i].Myprodsize  = myproddepdc.Myprodsize;
                    proddepstruct[i].Mylastadd  = myproddepdc.Mylastadd;
                    proddepstruct[i].Myretailprice  = myproddepdc.Myretailprice;
                    proddepstruct[i].Mybelognto = myproddepdc.Mybelognto;
                    proddepstruct[i].Myysbl  = myproddepdc.Myysbl;
                    
                    i++;
                }


                return proddepstruct;
            }


            catch
            {
                 m_proxy.Abort();
                throw;
            }
        }

           

          public static string invokmyuploadgjd(Uploadthegjdmainstruct uploadgjdmainstruct,Uploadthegjdsubstruct[] uploadgjdsubstruct,string wcfaddr, string theusername, string thepw)
          {

                 WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
                
                 WcfSvc.Uploadthegjdmaindatacontract uploadgjdmaindc = new WCFServiceWrapper.WcfSvc.Uploadthegjdmaindatacontract
                 {
                     Mylistnomain = uploadgjdmainstruct.Mylistnomain,
                     Myclinomain = uploadgjdmainstruct.Myclinomain,
                     Mylocaltimemain = uploadgjdmainstruct.Mylocaltimemain,
                     Mynowstatusmain = uploadgjdmainstruct.Mynowstatusmain,
                     Mybelongtomain = uploadgjdmainstruct.Mybelongtomain
                 };

                 WcfSvc.UploadthegjdsubList uploadgjdsublist = new WCFServiceWrapper.WcfSvc.UploadthegjdsubList();
                 

                 int reccount = uploadgjdsubstruct.Length;
                 int i = 0;
                 for (i = 0; i < reccount; i++)
                 {
                     WcfSvc.Uploadthegjdsub uploadgjdsubdc = new WCFServiceWrapper.WcfSvc.Uploadthegjdsub
                     {
                         Mylistnosub = uploadgjdsubstruct[i].Mylistnosub,
                         Myprodnosub = uploadgjdsubstruct[i].Myprodnosub,
                         Mystatusub = uploadgjdsubstruct[i].Mystatusub,
                         Mylesttimesub = uploadgjdsubstruct[i].Mylesttimesub,
                         Myneednumsub = uploadgjdsubstruct[i].Myneednumsub
                         
                     };

                     uploadgjdsublist.Add(uploadgjdsubdc);
                 }

                 try
                 {
                     string resultstring = m_proxy.Uploadthegjd(uploadgjdmaindc, uploadgjdsublist);
                     m_proxy.Close();
                     return resultstring;
                 }
                 catch
                 {
                     m_proxy.Abort();
                     throw;
                 }


          }

          public static MyInvMainStruct[] invokegetinvmaininfo(DateTime begintimemain, DateTime endtimemain, string clinomain, int belongtomain, string wcfaddr, string theusername, string thepw)
        {
            WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);

            WcfSvc.MyInvMainList myinvmainlist = new WCFServiceWrapper.WcfSvc.MyInvMainList();

            try
            {
                myinvmainlist = m_proxy.GetInvMaininfo(begintimemain, endtimemain, clinomain, belongtomain);
                int recordcount=myinvmainlist.Count;
                MyInvMainStruct[] invmainstruct = new MyInvMainStruct[recordcount];
                int i = 0;
                foreach (WcfSvc.MyInvMainDataContract myimdc in myinvmainlist)
                {
                    invmainstruct[i].Mylistnomain  = myimdc.Mylistnomain;
                    invmainstruct[i].Myclinomain  = myimdc.Myclinomain;
                    invmainstruct[i].Myclinamemain  = myimdc.Myclinamemain;
                    invmainstruct[i].Myinvdatemain  = myimdc.Myinvdatemain;
                    invmainstruct[i].Myinvmonmain  = myimdc.Myinvmonmain;
                    invmainstruct[i].Myinvmemomain  = myimdc.Myinvmemomain;
                    i++;
                }

                m_proxy.Close();
                return invmainstruct;
            }
            
            catch
            {
                     m_proxy.Abort();
                     throw;
            }

        }

          public static MyInvSubStruct[] invokgetinvsubinfo(string listnosubvar, int belongtosubvar, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
                   
              WcfSvc.MyInvSubList invsublist = new WCFServiceWrapper.WcfSvc.MyInvSubList();

              try
              {
                  invsublist = m_proxy.GetInvSubInfo(listnosubvar, belongtosubvar);
                  int recordcount = invsublist.Count;
                  MyInvSubStruct[] invsubstruct = new MyInvSubStruct[recordcount];
                  int i = 0;
                  foreach (WcfSvc.MyInvSubDataContract myisdc in invsublist)
                  {
                     invsubstruct[i].Myinvsubprodno=myisdc.Myinvsubprodno;
                     invsubstruct[i].Myinvsubprodname=myisdc.Myinvsubprodname;
                     invsubstruct[i].Myinvsubprodsize=myisdc.Myinvsubprodsize;
                     invsubstruct[i].Myinvsubmonad=myisdc.Myinvsubmonad;
                     invsubstruct[i].Myinvsubboxnum=myisdc.Myinvsubboxnum;
                     invsubstruct[i].Myinvsubwareno =myisdc.Myinvsubwareno;
                     invsubstruct[i].Myinvsubprodadd=myisdc.Myinvsubprodadd;
                     invsubstruct[i].Myinvsubbatchno=myisdc.Myinvsubbatchno;
                     invsubstruct[i].Myinvsubinvnum =myisdc.Myinvsubinvnum;
                     invsubstruct[i].Myinvsubstdprice=myisdc. Myinvsubstdprice;
                     invsubstruct[i].Myinvsubsellprice=myisdc. Myinvsubsellprice;
                     invsubstruct[i].Myinvsubavaildate=myisdc. Myinvsubavaildate;
                      invsubstruct[i].Myinvsubretailprice =myisdc.Myinvsubretailprice;
                      invsubstruct[i].Myinvsubprodmade =myisdc.Myinvsubprodmade;
                      invsubstruct[i].Myinvsubprodlabel =myisdc.Myinvsubprodlabel;
                       invsubstruct[i].Myinvsubprodpzwh =myisdc.Myinvsubprodpzwh;
                      invsubstruct[i].Myinvsubboxmidnum =myisdc.Myinvsubboxmidnum;
                      invsubstruct[i].Myinvsubbarcode = myisdc.Myinvsubbarcode;
                       i++;
                  }

                  m_proxy.Close();
                  return invsubstruct;

              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }




          }

          public static MyClientInfostruct[] invokclientinfo(string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);

              WcfSvc.MyClientInfolist clientlist = new WCFServiceWrapper.WcfSvc.MyClientInfolist();
              try
              {
                  clientlist = m_proxy.GetClientInfo();
                  int recordcount = clientlist.Count;
                  MyClientInfostruct[] clientstruct = new MyClientInfostruct[recordcount];
                  int i = 0;
                  foreach (WcfSvc.MyClientInfoDataContract clientdc in clientlist)
                  {
                         clientstruct[i].Myclientclino =clientdc.Myclientclino;
                         clientstruct[i].Myclientcliname =clientdc.Myclientcliname;
                         clientstruct[i].Myclientsumjf =clientdc.Myclientsumjf;
                         clientstruct[i].Myclientcliadd =clientdc.Myclientcliadd;
                         clientstruct[i].Myclientclitel =clientdc.Myclientclitel;
                          clientstruct[i].Myclientclimemo =clientdc.Myclientclimemo;
                          clientstruct[i].Myclientsex = clientdc.Myclientsex;
                          clientstruct[i].Mycliass = clientdc.Mycliass;
                          clientstruct[i].Mycliper = clientdc.Mycliper;
                          clientstruct[i].Myclienttypeno = clientdc.Myclienttypeno;
                          clientstruct[i].Myjf = clientdc.Myjf;
                          clientstruct[i].Mynl = clientdc.Mynl;
                          clientstruct[i].Myprjf = clientdc.Myprjf;
                          i++;
                  }
                  m_proxy.Close();
                  return clientstruct;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }

          }

          public static Myboxmediumstruct[] invokGetboxmidnum(string wcfaddr, string theusername, string thepw)
          {

              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);

              WcfSvc.Myboxmediumlist boxmediumlist = new WCFServiceWrapper.WcfSvc.Myboxmediumlist();
              try
              {
                  boxmediumlist = m_proxy.Getboxmidnum();
                  int recordcount = boxmediumlist.Count;
                  int i = 0;
                  Myboxmediumstruct[] boxmediumstruct = new Myboxmediumstruct[recordcount];
                  foreach (WcfSvc.MyboxmediumDataContract boxmediumdc in boxmediumlist)
                  {
                      boxmediumstruct[i].Myprodno  = boxmediumdc.Myprodno;
                      boxmediumstruct[i].Myprodname  = boxmediumdc.Myprodname;
                      boxmediumstruct[i].Myboxmidnum  = boxmediumdc.Myboxmidnum;
                      i++;
                  }
                  m_proxy.Close();
                  return boxmediumstruct;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }

          }

          public static MyProdfullStruct[] invokProdfull(string wcfaddr, string theusername, string thepw)
          {
             
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              

              try
              {


                  WcfSvc.MyProdfulllist prodfullist = new WCFServiceWrapper.WcfSvc.MyProdfulllist();
                  


                     prodfullist = m_proxy.GetMyProdfull();
                      
                      int recordcount = prodfullist.Count;
                      int i = 0;
                      MyProdfullStruct[] prodfullstruct = new MyProdfullStruct[recordcount];
                      foreach (WcfSvc.MyProdfullDatacontract  prodfulldc in prodfullist)
                      {
                          prodfullstruct[i].Myprodno = prodfulldc.Myprodno;
                          prodfullstruct[i].Myprodname = prodfulldc.Myprodname;
                          prodfullstruct[i].Myprodsize = prodfulldc.Myprodsize;
                          prodfullstruct[i].Mymonad = prodfulldc.Mymonad;
                          prodfullstruct[i].Mylastadd = prodfulldc.Mylastadd;
                          prodfullstruct[i].Mybarcode = prodfulldc.Mybarcode;
                          prodfullstruct[i].Myprodpzwh = prodfulldc.Myprodpzwh;
                          prodfullstruct[i].Mystdprice = prodfulldc.Mystdprice;
                          prodfullstruct[i].Myretailprice = prodfulldc.Myretailprice;
                          prodfullstruct[i].Myprodmade = prodfulldc.Myprodmade;
                          prodfullstruct[i].Myprodlabel = prodfulldc.Myprodlabel;
                          prodfullstruct[i].Mysellstop = prodfulldc.Mysellstop;
                          i++;
                      }


                      m_proxy.Close();
                      return prodfullstruct;

              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
            

          }



          public static MyProdfullStruct[] invokProdfullsingle(int mybleong,string wcfaddr, string theusername, string thepw)
          {
              
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
   

              foreach (var operationDescription in m_proxy.Endpoint.Contract.Operations)
              {
                  DataContractSerializerOperationBehavior dcsob =
                      operationDescription.Behaviors.Find<DataContractSerializerOperationBehavior>();
                  if (dcsob != null)
                  {
                      dcsob.MaxItemsInObjectGraph = 65536000;
                  }
              }



              try
              {


                  WcfSvc.MyProdfulllist prodfullist = new WCFServiceWrapper.WcfSvc.MyProdfulllist();



                  prodfullist = m_proxy.GetMyProdfullsingle(mybleong);

                  int recordcount = prodfullist.Count;
                  int i = 0;
                  MyProdfullStruct[] prodfullstruct = new MyProdfullStruct[recordcount];
                  foreach (WcfSvc.MyProdfullDatacontract prodfulldc in prodfullist)
                  {
                      prodfullstruct[i].Myprodno = prodfulldc.Myprodno;
                      prodfullstruct[i].Myprodname = prodfulldc.Myprodname;
                      prodfullstruct[i].Myprodsize = prodfulldc.Myprodsize;
                      prodfullstruct[i].Mymonad = prodfulldc.Mymonad;
                      prodfullstruct[i].Mylastadd = prodfulldc.Mylastadd;
                      prodfullstruct[i].Mybarcode = prodfulldc.Mybarcode;
                      prodfullstruct[i].Myprodpzwh = prodfulldc.Myprodpzwh;
                      prodfullstruct[i].Mystdprice = prodfulldc.Mystdprice;
                      prodfullstruct[i].Myretailprice = prodfulldc.Myretailprice;
                      prodfullstruct[i].Myprodmade = prodfulldc.Myprodmade;
                      prodfullstruct[i].Myprodlabel = prodfulldc.Myprodlabel;
                      prodfullstruct[i].Mysellstop = prodfulldc.Mysellstop;
                      i++;
                  }


                  m_proxy.Close();
                  return prodfullstruct;

              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }


          }


          public static MyProdrecipeStruct[] invokGetProdrecip(string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
                   
              WcfSvc.MyProdrecipelist prodrecipelist = new WCFServiceWrapper.WcfSvc.MyProdrecipelist();
              try
              {
                  prodrecipelist = m_proxy.GetProdrecip();
                  int recordcount = prodrecipelist.Count;
                  int i = 0;
                  MyProdrecipeStruct[] prodrecipestruct = new MyProdrecipeStruct[recordcount];
                  foreach (WcfSvc.MyProdrecipeDataContract prodrecipedc in prodrecipelist)
                  {
                      prodrecipestruct[i].Myprodno = prodrecipedc.Myprodno;
                      prodrecipestruct[i].Myprodname = prodrecipedc.Myprodname;
                      prodrecipestruct[i].Myrecipe = prodrecipedc.Myrecipe;
                      i++;
                  }
                  m_proxy.Close();
                  return prodrecipestruct;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
          }


          public static SimilarProdnamestruct[] invokSimilarProdname(string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);

              WcfSvc.SimilarProdnamelist similarnamelist = new WCFServiceWrapper.WcfSvc.SimilarProdnamelist();
              try
              {
                  similarnamelist = m_proxy.Getsimilarprodname();
                  int recordcount = similarnamelist.Count;
                  int i = 0;
                  SimilarProdnamestruct[] simlarnamestruct = new SimilarProdnamestruct[recordcount];
                  foreach (WcfSvc.SimilarProdnameDatacontract similarnamedc in similarnamelist)
                  {
                      simlarnamestruct[i].Myprodnofir = similarnamedc.Myprodnofir;
                      simlarnamestruct[i].Myprodnamefir = similarnamedc.Myprodnamefir;
                      simlarnamestruct[i].Myprodsizefir = similarnamedc.Myprodsizefir;
                      simlarnamestruct[i].Mymonadfir = similarnamedc.Mymonadfir;
                      simlarnamestruct[i].Mysellstopfir = similarnamedc.Mysellstopfir;
                      simlarnamestruct[i].Mylastaddfir = similarnamedc.Mylastaddfir;
                      simlarnamestruct[i].Myprodnasecfir = similarnamedc.Myprodnasecfir;
                      simlarnamestruct[i].Mydepnumfir = similarnamedc.Mydepnumfir;
                      simlarnamestruct[i].Mybelongfir = similarnamedc.Mybelongfir;
                      simlarnamestruct[i].Mybuypricefir = similarnamedc.Mybuypricefir;
                      simlarnamestruct[i].Myprodnosec = similarnamedc.Myprodnosec;
                      simlarnamestruct[i].Myprodnamesec = similarnamedc.Myprodnamesec;
                      simlarnamestruct[i].Myprodsizesec = similarnamedc.Myprodsizesec;
                      simlarnamestruct[i].Mymonadsec = similarnamedc.Mymonadsec;
                      simlarnamestruct[i].Mysellstopsec = similarnamedc.Mysellstopsec;
                      simlarnamestruct[i].Mylastaddsec = similarnamedc.Mylastaddsec;
                      simlarnamestruct[i].Myprodnasecsec = similarnamedc.Myprodnasecsec;
                      simlarnamestruct[i].Mydepnumsec = similarnamedc.Mydepnumsec;
                      simlarnamestruct[i].Mybelongsec = similarnamedc.Mybelongsec;
                      simlarnamestruct[i].Mybuypricesec = similarnamedc.Mybuypricesec;
                      i++;
                  }
                  m_proxy.Close();
                  return simlarnamestruct;


              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }

          }


          public static int invokeuploadfiveprod(Uploadfiveprodstr[] upldfiveprodstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Uploadfiveproddatalist uploadfiveproddatalist = new WcfSvc.Uploadfiveproddatalist();
              int num = upldfiveprodstr.Length;
              for (int i = 0; i < num; i++)
              {
                  WcfSvc.Uploadfiveproddatacontract item = new WcfSvc.Uploadfiveproddatacontract
                  {
                      Mylistno = upldfiveprodstr[i].Mylistno,
                      Myinvdate = upldfiveprodstr[i].Myinvdate,
                      Myprodno = upldfiveprodstr[i].Myprodno,
                      Myprodname = upldfiveprodstr[i].Myprodname,
                      Myprodadd = upldfiveprodstr[i].Myprodadd,
                      Mybatchno = upldfiveprodstr[i].Mybatchno,
                      Myinvnum = upldfiveprodstr[i].Myinvnum,
                      Mystdprice = upldfiveprodstr[i].Mystdprice,
                      Mysellprice = upldfiveprodstr[i].Mysellprice,
                      Myclino = upldfiveprodstr[i].Myclino,
                      Myinvbywho = upldfiveprodstr[i].Myinvbywho,
                      Mymdno = upldfiveprodstr[i].Mymdno
                  };
                  uploadfiveproddatalist.Add(item);
              }
              int result;
              try
              {
                  int num2 = m_proxy.uploadfiveprod(uploadfiveproddatalist);
                  m_proxy.Close();
                  result = num2;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              return result;
          }


          public static int invokeupgjdver2(Uploadthegjdmaindcver2struct upgjdver2str, Uploadthegjdsubver2struct[] upgjdsubver2str, ref LackofGoodstruct[] lackstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Uploadthegjdmaindcver2 gjdmaindc = new WcfSvc.Uploadthegjdmaindcver2
              {
                  Mylistnomain = upgjdver2str.Mylistnomain,
                  Myclinomain = upgjdver2str.Myclinomain,
                  Myclinozymain = upgjdver2str.Myclinozymain,
                  Mylocaltimemain = upgjdver2str.Mylocaltimemain,
                  Mynowstatusmain = upgjdver2str.Mynowstatusmain
              };
              WcfSvc.Uploadthegjdsubver2List uploadthegjdsubver2List = new WcfSvc.Uploadthegjdsubver2List();
              int recordcount = upgjdsubver2str.Length;
              
              for (int i = 0; i < recordcount; i++)
              {
                  WcfSvc.Uploadthegjdsubver2 item = new WcfSvc.Uploadthegjdsubver2
                  {
                      Mylistnosub = upgjdsubver2str[i].Mylistnosub,
                      Myprodnosub = upgjdsubver2str[i].Myprodnosub,
                      Myprodnamesub = upgjdsubver2str[i].Myprodnamesub,
                      Mylastaddsub = upgjdsubver2str[i].Mylastaddsub,
                      Myneednumsub = upgjdsubver2str[i].Myneednumsub,
                      Mystatusub = upgjdsubver2str[i].Mystatusub,
                      Mylesttimesub = upgjdsubver2str[i].Mylesttimesub,
                      Mybelong = 0,
                      Myreason = 0
                  };
                  uploadthegjdsubver2List.Add(item);
              }
              WcfSvc.Lackofgoodlist lackofgoodlist = new WcfSvc.Lackofgoodlist();
              int result;
              try
              {
                  result = m_proxy.Uploadthegjdver2(gjdmaindc, uploadthegjdsubver2List, ref lackofgoodlist);
                  int count = lackofgoodlist.Count;
                  if (count > 0)
                  {
                      lackstr = new LackofGoodstruct[count];
                      int i = 0;
                      foreach (WcfSvc.LackofGoodatacontract lackofgooddc in lackofgoodlist)
                      {
                          lackstr[i].Mygjdno = lackofgooddc.Mygjdno;
                          lackstr[i].Myprodno = lackofgooddc.Myprodno;
                          lackstr[i].lackreason = lackofgooddc.lackreason;
                          i++;
                      }
                  }
                  m_proxy.Close();
                  return result;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              
          }

          public static int invokeCheckkcbelong(Checkkcretbelongstruct[] checkkcbelongstr, string cli_no, ref Prodbelongtostruct[] prodbelongstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.CheckkcretbelongList checkkcretbelongList = new WcfSvc.CheckkcretbelongList();
              int recordcount = checkkcbelongstr.Length;
              for (int i = 0; i < recordcount; i++)
              {
                  WcfSvc.Checkkcretbelong item = new WcfSvc.Checkkcretbelong
                  {
                      Myprodno = checkkcbelongstr[i].Myprodno,
                      Myprodname = checkkcbelongstr[i].Myprodname,
                      Mylastadd = checkkcbelongstr[i].Mylastadd,
                      Mymonad = checkkcbelongstr[i].Mymonad
                  };
                  checkkcretbelongList.Add(item);
              }
              WcfSvc.Prodbelonglist prodbelonglist = new WcfSvc.Prodbelonglist();
              int result;
              try
              {
                  int theresult = m_proxy.Checkkcbelong(checkkcretbelongList, cli_no, ref prodbelonglist);
                  int therecordcount = prodbelonglist.Count;
                  prodbelongstr = new Prodbelongtostruct[therecordcount];
                  for (int i = 0; i < therecordcount; i++)
                  {
                      prodbelongstr[i].Myprodno = prodbelonglist[i].Myprodno;
                      prodbelongstr[i].Mybelongto = prodbelonglist[i].Mybelongto;
                  }
                  m_proxy.Close();
                  result = 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              return result;
          }

          public static int invokeUploadthekc(Uploadkcmainstruct upkcmainstr, Uploadkcsubstruct[] upkcsubstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Uploadkcmaindc kcmaindc = new WcfSvc.Uploadkcmaindc
              {
                  Mylistnomain = upkcmainstr.Mylistnomain,
                  Myclinomain = upkcmainstr.Myclinomain,
                  Myclinozymain = upkcmainstr.Myclinozymain,
                  Mynowstatusmain = upkcmainstr.Mynowstatusmain
              };
              WcfSvc.UploadkcsubdcList uploadkcsubdcList = new WcfSvc.UploadkcsubdcList();
              for (int i = 0; i < upkcsubstr.Length; i++)
              {
                  WcfSvc.Uploadkcsubdc item = new WcfSvc.Uploadkcsubdc
                  {
                      Mylnumno = upkcsubstr[i].Mylnumno,
                      Myprodno = upkcsubstr[i].Myprodno,
                      Mystdprice = upkcsubstr[i].Mystdprice,
                      Myinvnum = upkcsubstr[i].Myinvnum,
                      Mydepdate = upkcsubstr[i].Mydepdate,
                      Mylestnum = upkcsubstr[i].Mylestnum,
                      Mylnum = upkcsubstr[i].Mylnum,
                      theblongto = upkcsubstr[i].theblongto
                  };
                  uploadkcsubdcList.Add(item);
              }
              int result;
              try
              {
                  int num = m_proxy.Uploadthekc(kcmaindc, uploadkcsubdcList);
                  m_proxy.Close();
                  result = 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              return result;
          }


          public static int invokeCheckretbelg(Checkkcretbelongstruct[] checkkcbelongstr, string cli_no, ref Prodbelongtostruct[] prodbelongstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.CheckkcretbelongList checkkcretbelongList = new WcfSvc.CheckkcretbelongList();
              int recordcount = checkkcbelongstr.Length;
              for (int i = 0; i < recordcount; i++)
              {
                  WcfSvc.Checkkcretbelong item = new WcfSvc.Checkkcretbelong
                  {
                      Myprodno = checkkcbelongstr[i].Myprodno,
                      Myprodname = checkkcbelongstr[i].Myprodname,
                      Mylastadd = checkkcbelongstr[i].Mylastadd,
                      Mybatchno = checkkcbelongstr[i].Mybatchno,
                      Mymonad = checkkcbelongstr[i].Mymonad
                  };
                  checkkcretbelongList.Add(item);
              }
              WcfSvc.Prodbelonglist prodbelonglist = new WcfSvc.Prodbelonglist();
              int result;
              try
              {
                  result = m_proxy.Checkretbelong(checkkcretbelongList, cli_no, ref prodbelonglist);
                  int therecordcount= prodbelonglist.Count;
                  prodbelongstr = new Prodbelongtostruct[therecordcount];
                  for (int i = 0; i < therecordcount; i++)
                  {
                      prodbelongstr[i].Myprodno = prodbelonglist[i].Myprodno;
                      prodbelongstr[i].Mybatchno = prodbelonglist[i].Mybatchno;
                      prodbelongstr[i].Mybelongto = prodbelonglist[i].Mybelongto;
                  }
                  m_proxy.Close();
                  return 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
             
          }


          public static int invokeUploadret(Uploadkcmainstruct upretmainstr, Uploadret2substruct[] upretsubstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Uploadkcmaindc retmaindc = new WcfSvc.Uploadkcmaindc
              {
                  Mylistnomain = upretmainstr.Mylistnomain,
                  Myclinomain = upretmainstr.Myclinomain,
                  Myclinozymain = upretmainstr.Myclinozymain,
                  Mynowstatusmain = upretmainstr.Mynowstatusmain
              };
              WcfSvc.Uploadret2subdclist uploadret2subdclist = new WcfSvc.Uploadret2subdclist();
              for (int i = 0; i < upretsubstr.Length; i++)
              {
                  WcfSvc.Uploadret2subdc item = new WcfSvc.Uploadret2subdc
                  {
                      Mylnumno = upretsubstr[i].Mylnumno,
                      Myprodno = upretsubstr[i].Myprodno,
                      Myprodadd = upretsubstr[i].Myprodadd,
                      Mybatchno = upretsubstr[i].Mybatchno,
                      Myretnum = upretsubstr[i].Myretnum,
                      Mybuyprice = upretsubstr[i].Mybuyprice,
                      Mystdprice = upretsubstr[i].Mystdprice,
                      theblongto = upretsubstr[i].theblongto
                  };
                  uploadret2subdclist.Add(item);
              }
              
              try
              {
                  int result = m_proxy.Uploadtheret(retmaindc, uploadret2subdclist);
                  m_proxy.Close();
                  return result;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              
          }


          public static int Gettheautodep(ref Bzkstruct[] bzkstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Bzkdclist bzkdclist = new WcfSvc.Bzkdclist();
              int result;
              try
              {
                  bzkdclist = m_proxy.Gettheautodep();
                  int recordcount = bzkdclist.Count;
                  bzkstr = new Bzkstruct[recordcount];
                  int num2 = 0;
                  foreach (WcfSvc.Bzkdc bzkdc in bzkdclist)
                  {
                      bzkstr[num2].Myprodno = bzkdc.Myprodno;
                      bzkstr[num2].Myprodnanme = bzkdc.Myprodnanme;
                      bzkstr[num2].Mylastadd = bzkdc.Mylastadd;
                      bzkstr[num2].Mybz = bzkdc.Mybz;
                      num2++;
                  }
                  m_proxy.Close();
                  result = 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              return result;
          }


          public static int Getthebth(ref Strkstruct[] strstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Strkdclist strkdclist = new WcfSvc.Strkdclist();
              
              try
              {
                  strkdclist = m_proxy.Getthebth();
                  int reordcount = strkdclist.Count;
                  strstr = new Strkstruct[reordcount];
                  int i = 0;
                  foreach (WcfSvc.Strkdc strkdc in strkdclist)
                  {
                      strstr[i].Myprodno = strkdc.Myprodno;
                      strstr[i].Myprodnanme = strkdc.Myprodnanme;
                      strstr[i].Mylastadd = strkdc.Mylastadd;
                      strstr[i].Mystr = strkdc.Mystr;
                      i++;
                  }
                  m_proxy.Close();
                  return 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
             
          }

          public static int Gettheoldgf(ref Strkstruct[] oldgfstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Strkdclist strkdclist = new WcfSvc.Strkdclist();
              int result;
              try
              {
                  strkdclist = m_proxy.Getoldgf();
                  int recordcount = strkdclist.Count;
                  oldgfstr = new Strkstruct[recordcount];
                  int i = 0;
                  foreach (WcfSvc.Strkdc strkdc in strkdclist)
                  {
                      oldgfstr[i].Myprodno = strkdc.Myprodno;
                      oldgfstr[i].Myprodnanme = strkdc.Myprodnanme;
                      oldgfstr[i].Mylastadd = strkdc.Mylastadd;
                      oldgfstr[i].Mystr = strkdc.Mystr;
                      i++;
                  }
                  m_proxy.Close();
                  result = 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              return result;
          }


          public static int Gettheoldgfsingle(ref Strkstruct[] oldgfstr, int thedb,string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Strkdclist strkdclist = new WcfSvc.Strkdclist();
              int result;
              try
              {
                  strkdclist = m_proxy.Getoldgfsingle(thedb);
                  int recordcount = strkdclist.Count;
                  oldgfstr = new Strkstruct[recordcount];
                  int i = 0;
                  foreach (WcfSvc.Strkdc strkdc in strkdclist)
                  {
                      oldgfstr[i].Myprodno = strkdc.Myprodno;
                      oldgfstr[i].Myprodnanme = strkdc.Myprodnanme;
                      oldgfstr[i].Mylastadd = strkdc.Mylastadd;
                      oldgfstr[i].Mystr = strkdc.Mystr;
                      i++;
                  }
                  m_proxy.Close();
                  result = 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              return result;
          }



          public static int Getthenewgf(ref Dblkstruct[] newgfstr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Dblkdclist dblkdclist = new WcfSvc.Dblkdclist();
              int result;
              try
              {
                  dblkdclist =  m_proxy.Getnewgf();
                  int recordcount = dblkdclist.Count;
                  newgfstr = new Dblkstruct[recordcount];
                  int i = 0;
                  foreach (WcfSvc.Dblkdc dblkdc in dblkdclist)
                  {
                      newgfstr[i].Myprodno = dblkdc.Myprodno;
                      newgfstr[i].Myprodnanme = dblkdc.Myprodnanme;
                      newgfstr[i].Mylastadd = dblkdc.Mylastadd;
                      newgfstr[i].Mydbl = dblkdc.Mydbl;
                      i++;
                  }
                  m_proxy.Close();
                  result = 1;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
              return result;
          }


          public static int Uploaddep(Depdc[] depstr, string cli_no, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.Depdclist depdclist = new WcfSvc.Depdclist();
              int recordcount = depstr.Length;
              for (int i = 0; i < recordcount; i++)
              {
                  WcfSvc.Depdc thedepdc = new WcfSvc.Depdc
                  {
                      Myprodno = depstr[i].Myprodno,
                      Myprodname = depstr[i].Myprodname,
                      Myprodadd = depstr[i].Myprodadd,
                      Mybatchno = depstr[i].Mybatchno,
                      Myboxnum = depstr[i].Myboxnum,
                      Mylestnum = depstr[i].Mylestnum,
                      Myavaildate = depstr[i].Myavaildate,
                      Mystdprice = depstr[i].Mystdprice
                  };
                  depdclist.Add(thedepdc);
              }
              
              try
              {
                  int result = m_proxy.Uploaddep(depdclist, cli_no);
                  m_proxy.Close();
                  return result;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
           
          }
          public static int Uploadchgprice(Changepricestr[] chgpricestr, string cli_no, int sfwrtype, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              WcfSvc.changepricelist changepricelist = new WcfSvc.changepricelist();
              int num = chgpricestr.Length;
              for (int i = 0; i < num; i++)
              {
                  WcfSvc.Changeprice Changepricedc = new WcfSvc.Changeprice
                  {
                      changedate = chgpricestr[i].changedate,
                      prodno = chgpricestr[i].prodno,
                      prodname = chgpricestr[i].prodname,
                      batchno = chgpricestr[i].batchno,
                      prodadd = chgpricestr[i].prodadd,
                      prodsize = chgpricestr[i].prodsize,
                      monad = chgpricestr[i].monad,
                      lestnum = chgpricestr[i].lestnum,
                      old_std_price = chgpricestr[i].old_std_price,
                      new_std_price = chgpricestr[i].new_std_price
                  };
                  changepricelist.Add(Changepricedc);
              }
              
              try
              {
                  int result = m_proxy.Uploadchangeprice(changepricelist, cli_no, sfwrtype);
                  m_proxy.Close();
                  return result;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }
             
          }

          public static int Getinvinfo(ref Invfullinfostr[] invstr, ref string counts, ref string pagecount, querypostinfo querystr, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              try
              {
                  WcfSvc.querypostinfo qr=new WCFServiceWrapper.WcfSvc.querypostinfo
                  {
                      begtime=querystr.begtime ,
                      endtime=querystr.endtime,
                      cli_no =querystr.cli_no ,
                      thebelong =querystr.thebelong ,
                      pageIndex=querystr.pageIndex ,
                      pageSize =querystr.pageSize 
                  };
                  WcfSvc.Invfullinfolist invfs=new WCFServiceWrapper.WcfSvc.Invfullinfolist();
                  int mypagecount=0;
                  int myreccount = 0;
                  invfs = m_proxy.Getinvinfo( out mypagecount, out myreccount,qr);

                  counts = mypagecount.ToString();
                  pagecount = myreccount.ToString();

       ///           System.Windows.Forms.MessageBox.Show("mypagecount" + mypagecount.ToString());
                  ///     System.Windows.Forms.MessageBox.Show("myreccount" + myreccount.ToString());
                  ///      System.Windows.Forms.MessageBox.Show("counts " + counts.ToString());
                  ///      System.Windows.Forms.MessageBox.Show("pagecount" + pagecount.ToString());

                  int thecount = invfs.Count();
                  invstr = new Invfullinfostr[thecount];
                  int num = 0;
                  foreach (WcfSvc.Invfullinfo invf in invfs)
                  {
                      invstr[num].prodno = invf.prodno;
                      invstr[num].listno = invf.listno;
                      invstr[num].invdate = invf.invdate;
                      invstr[num].prodname = invf.prodname;
                      invstr[num].prodsize = invf.prodsize;
                      invstr[num].prodadd = invf.prodadd;
                      invstr[num].monad = invf.monad;
                      invstr[num].batchno = invf.batchno;
                      invstr[num].availdate = invf.availdate;
                      invstr[num].invnum = invf.invnum;
                      invstr[num].sellprice = invf.sellprice;
                      invstr[num].retailprice = invf.retailprice;
                      invstr[num].prodpzwh = invf.prodpzwh;
                      num++;
 
                  }

                  m_proxy.Close();
                  return 0;
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }

          }


          public static int Getdepfullinfo(ref lestmodelstr[] leststr,int thebelong,string wcfaddr, string theusername, string thepw)
          {
               WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
              try
              {
                   WcfSvc.lestmodellist lests=new WCFServiceWrapper.WcfSvc.lestmodellist();
                  
                    lests=m_proxy.Getthedepinfo(thebelong);
                    int count=lests.Count();
                     
                    leststr=new lestmodelstr[count];
                    int num=0;
                   foreach ( WcfSvc.lestmodel lest in lests)
                   {
                      leststr[num].prodno=lest.prodno ;
                      leststr[num].prodname=lest.prodname ;
                      leststr[num].prodsize =lest.prodsize ;
                      leststr[num].monad =lest.monad ;
                      leststr[num].batchno=lest.batchno ;
                      leststr[num].prodadd=lest.prodadd ;
                      leststr[num].lestnum =lest.lestnum ;
                      leststr[num].availdate =lest.availdate ;
                       num++;
                   }
                  m_proxy.Close();
                 return 0;
              }
              catch
              {
                   m_proxy.Abort();
                  throw;
              }
          }

          public static DateTime invokegetime(string wcfaddr, string theusername, string thepw)
          {

              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);
            

              try
              {
                  DateTime theservertime = m_proxy.getthedatetime();
                  m_proxy.Close();
                  return theservertime;
              
              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }

          }

          public static MyInvSubStruct2[] invokgetinvsubinfo2(string listnosubvar, int belongtosubvar, string wcfaddr, string theusername, string thepw)
          {
              WcfSvc.Service1Client m_proxy = getclientproxy(wcfaddr, theusername, thepw);

              WcfSvc.MyInvSubList2 invsublist = new WCFServiceWrapper.WcfSvc.MyInvSubList2();

              try
              {
                  invsublist = m_proxy.GetInvSubInfo2(listnosubvar, belongtosubvar);
                  int recordcount = invsublist.Count;
                  MyInvSubStruct2[] invsubstruct = new MyInvSubStruct2[recordcount];
                  int i = 0;
                  foreach (WcfSvc.MyInvSubDataContract2 myisdc in invsublist)
                  {
                      invsubstruct[i].Myinvsubprodno = myisdc.Myinvsubprodno;
                      invsubstruct[i].Myinvsubprodname = myisdc.Myinvsubprodname;
                      invsubstruct[i].Myinvsubprodsize = myisdc.Myinvsubprodsize;
                      invsubstruct[i].Myinvsubmonad = myisdc.Myinvsubmonad;
                      invsubstruct[i].Myinvsubboxnum = myisdc.Myinvsubboxnum;
                      invsubstruct[i].Myinvsubwareno = myisdc.Myinvsubwareno;
                      invsubstruct[i].Myinvsubprodadd = myisdc.Myinvsubprodadd;
                      invsubstruct[i].Myinvsubbatchno = myisdc.Myinvsubbatchno;
                      invsubstruct[i].Myinvsubinvnum = myisdc.Myinvsubinvnum;
                      invsubstruct[i].Myinvsubstdprice = myisdc.Myinvsubstdprice;
                      invsubstruct[i].Myinvsubsellprice = myisdc.Myinvsubsellprice;
                      invsubstruct[i].Myinvsubavaildate = myisdc.Myinvsubavaildate;
                      invsubstruct[i].Myinvsubretailprice = myisdc.Myinvsubretailprice;
                      invsubstruct[i].Myinvsubprodmade = myisdc.Myinvsubprodmade;
                      invsubstruct[i].Myinvsubprodlabel = myisdc.Myinvsubprodlabel;
                      invsubstruct[i].Myinvsubprodpzwh = myisdc.Myinvsubprodpzwh;
                      invsubstruct[i].Myinvsubboxmidnum = myisdc.Myinvsubboxmidnum;
                      invsubstruct[i].Myinvsubbarcode = myisdc.Myinvsubbarcode;
                      invsubstruct[i].Myproducedate = myisdc.Myproducedate;
                      i++;
                  }

                  m_proxy.Close();
                  return invsubstruct;

              }
              catch
              {
                  m_proxy.Abort();
                  throw;
              }




          }


          public static WcfSvc.Service1Client getclientproxy(string wcfaddr, string theusername, string thepw)
          {




              EndpointAddress objAddress = new EndpointAddress(new Uri(wcfaddr + "/Service1.svc"), EndpointIdentity.CreateDnsIdentity("WCFServerPK"));
              
              WSHttpBinding wshttpbind = new WSHttpBinding();
              wshttpbind.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;

              wshttpbind.ReliableSession.Enabled = false;
              wshttpbind.TransactionFlow = false;
              wshttpbind.MaxBufferPoolSize = 524288000;
              wshttpbind.MaxReceivedMessageSize = 65536000;
              wshttpbind.CloseTimeout = new TimeSpan(0, 5, 0);
              wshttpbind.OpenTimeout = new TimeSpan(0, 5, 0);
              wshttpbind.ReceiveTimeout = new TimeSpan(0, 5, 0);
              wshttpbind.SendTimeout = new TimeSpan(0, 5, 0);
              
              wshttpbind.Security.Mode = SecurityMode.Message;
              wshttpbind.Security.Message.ClientCredentialType = MessageCredentialType.None;
              wshttpbind.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
              
              WcfSvc.Service1Client clientproxy = new WcfSvc.Service1Client(wshttpbind, objAddress);


              
              clientproxy.ClientCredentials.ClientCertificate.SetCertificate(
                        StoreLocation.CurrentUser ,
                        StoreName.My,
                        X509FindType.FindBySubjectName,
                        "WCFServerPK");
              clientproxy.ClientCredentials.UserName.UserName = theusername;
              clientproxy.ClientCredentials.UserName.Password = thepw;

              foreach (var operationDescription in clientproxy.Endpoint.Contract.Operations)
              {
                  DataContractSerializerOperationBehavior dcsob =
                      operationDescription.Behaviors.Find<DataContractSerializerOperationBehavior>();
                  if (dcsob != null)
                  {
                      dcsob.MaxItemsInObjectGraph = 65536000;
                  }
              }



              return clientproxy;
          }


        

        








    }


         
    

    

}
