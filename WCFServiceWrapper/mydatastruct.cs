using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFServiceWrapper
{
   
        public struct Bzkstruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodnanme
            {
                get;
                set;
            }
            public string Mylastadd
            {
                get;
                set;
            }
            public int Mybz
            {
                get;
                set;
            }
        }

        public struct Changepricestr
        {
            public DateTime changedate
            {
                get;
                set;
            }
            public string prodno
            {
                get;
                set;
            }
            public string prodname
            {
                get;
                set;
            }
            public string prodsize
            {
                get;
                set;
            }
            public string prodadd
            {
                get;
                set;
            }
            public string batchno
            {
                get;
                set;
            }
            public string monad
            {
                get;
                set;
            }
            public double lestnum
            {
                get;
                set;
            }
            public double old_std_price
            {
                get;
                set;
            }
            public double new_std_price
            {
                get;
                set;
            }
        }
        public struct Checkkcretbelongstruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodname
            {
                get;
                set;
            }
            public string Mylastadd
            {
                get;
                set;
            }
            public string Mymonad
            {
                get;
                set;
            }
            public string Mybatchno
            {
                get;
                set;
            }
        }

        public struct Dblkstruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodnanme
            {
                get;
                set;
            }
            public string Mylastadd
            {
                get;
                set;
            }
            public double Mydbl
            {
                get;
                set;
            }
        }
        public struct Depdc
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodname
            {
                get;
                set;
            }
            public string Myprodadd
            {
                get;
                set;
            }
            public string Mybatchno
            {
                get;
                set;
            }
            public double Mylestnum
            {
                get;
                set;
            }
            public string Myboxnum
            {
                get;
                set;
            }
            public DateTime Myavaildate
            {
                get;
                set;
            }
            public double Mystdprice
            {
                get;
                set;
            }
        }
        public struct LackofGoodstruct
        {
            public string Mygjdno
            {
                get;
                set;
            }
            public string Myprodno
            {
                get;
                set;
            }
            public int lackreason
            {
                get;
                set;
            }
        }

        public struct Myboxmediumstruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodname
            {
                get;
                set;
            }
            public string Myboxmidnum
            {
                get;
                set;
            }
        }

        public struct MyClientInfostruct
        {
            public string Myclientclino
            {
                get;
                set;
            }
            public string Myclientcliname
            {
                get;
                set;
            }
            public double Myclientsumjf
            {
                get;
                set;
            }
            public string Myclientcliadd
            {
                get;
                set;
            }
            public string Myclientclitel
            {
                get;
                set;
            }
            public string Myclientclimemo
            {
                get;
                set;
            }
            public string Myclientsex
            {
                get;
                set;
            }
            public string Mycliass
            {
                get;
                set;
            }
            public double Mycliper
            {
                get;
                set;
            }
            public string Myclienttypeno
            {
                get;
                set;
            }
            public int Myjf
            {
                get;
                set;
            }
            public int Mynl
            {
                get;
                set;
            }
            public int Myprjf
            {
                get;
                set;
            }
        }
        public struct MyInvMainStruct
        {
            public string Mylistnomain
            {
                get;
                set;
            }
            public string Myclinomain
            {
                get;
                set;
            }
            public string Myclinamemain
            {
                get;
                set;
            }
            public DateTime Myinvdatemain
            {
                get;
                set;
            }
            public double Myinvmonmain
            {
                get;
                set;
            }
            public string Myinvmemomain
            {
                get;
                set;
            }
        }

        public struct MyInvSubStruct
        {
            public string Myinvsubprodno
            {
                get;
                set;
            }
            public string Myinvsubprodname
            {
                get;
                set;
            }
            public string Myinvsubprodsize
            {
                get;
                set;
            }
            public string Myinvsubmonad
            {
                get;
                set;
            }
            public string Myinvsubboxnum
            {
                get;
                set;
            }
            public string Myinvsubwareno
            {
                get;
                set;
            }
            public string Myinvsubprodadd
            {
                get;
                set;
            }
            public string Myinvsubbatchno
            {
                get;
                set;
            }
            public double Myinvsubinvnum
            {
                get;
                set;
            }
            public double Myinvsubstdprice
            {
                get;
                set;
            }
            public double Myinvsubsellprice
            {
                get;
                set;
            }
            public DateTime Myinvsubavaildate
            {
                get;
                set;
            }
            public double Myinvsubretailprice
            {
                get;
                set;
            }
            public string Myinvsubprodmade
            {
                get;
                set;
            }
            public string Myinvsubprodlabel
            {
                get;
                set;
            }
            public string Myinvsubprodpzwh
            {
                get;
                set;
            }
            public string Myinvsubboxmidnum
            {
                get;
                set;
            }
            public string Myinvsubbarcode
            {
                get;
                set;
            }
        }

        public struct MyProdfullStruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodname
            {
                get;
                set;
            }
            public string Myprodsize
            {
                get;
                set;
            }
            public string Mymonad
            {
                get;
                set;
            }
            public string Mylastadd
            {
                get;
                set;
            }
            public string Mybarcode
            {
                get;
                set;
            }
            public string Myprodpzwh
            {
                get;
                set;
            }
            public double Mystdprice
            {
                get;
                set;
            }
            public double Myretailprice
            {
                get;
                set;
            }
            public string Myprodmade
            {
                get;
                set;
            }
            public string Myprodlabel
            {
                get;
                set;
            }
            public bool Mysellstop
            {
                get;
                set;
            }
        }

        public struct MyProdrecipeStruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodname
            {
                get;
                set;
            }
            public bool Myrecipe
            {
                get;
                set;
            }
        }

        public struct Prodbelongtostruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Mybatchno
            {
                get;
                set;
            }
            public int Mybelongto
            {
                get;
                set;
            }
        }
        public struct Proddepinfostruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodname
            {
                get;
                set;
            }
            public string Myprodsize
            {
                get;
                set;
            }
            public string Mylastadd
            {
                get;
                set;
            }
            public double Myretailprice
            {
                get;
                set;
            }
            public int Mybelognto
            {
                get;
                set;
            }
            public int Myysbl
            {
                get;
                set;
            }
        }
        public struct SimilarProdnamestruct
        {
            public string Myprodnofir
            {
                get;
                set;
            }
            public string Myprodnamefir
            {
                get;
                set;
            }
            public string Myprodsizefir
            {
                get;
                set;
            }
            public string Mymonadfir
            {
                get;
                set;
            }
            public bool Mysellstopfir
            {
                get;
                set;
            }
            public string Mylastaddfir
            {
                get;
                set;
            }
            public string Myprodnasecfir
            {
                get;
                set;
            }
            public double Mydepnumfir
            {
                get;
                set;
            }
            public string Mybelongfir
            {
                get;
                set;
            }
            public double Mybuypricefir
            {
                get;
                set;
            }
            public string Myprodnosec
            {
                get;
                set;
            }
            public string Myprodnamesec
            {
                get;
                set;
            }
            public string Myprodsizesec
            {
                get;
                set;
            }
            public string Mymonadsec
            {
                get;
                set;
            }
            public bool Mysellstopsec
            {
                get;
                set;
            }
            public string Mylastaddsec
            {
                get;
                set;
            }
            public string Myprodnasecsec
            {
                get;
                set;
            }
            public double Mydepnumsec
            {
                get;
                set;
            }
            public string Mybelongsec
            {
                get;
                set;
            }
            public double Mybuypricesec
            {
                get;
                set;
            }
        }

        public struct Strkstruct
        {
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodnanme
            {
                get;
                set;
            }
            public string Mylastadd
            {
                get;
                set;
            }
            public string Mystr
            {
                get;
                set;
            }
        }

        public struct Uploadfiveprodstr
        {
            public string Mylistno
            {
                get;
                set;
            }
            public DateTime Myinvdate
            {
                get;
                set;
            }
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodname
            {
                get;
                set;
            }
            public string Myprodadd
            {
                get;
                set;
            }
            public string Mybatchno
            {
                get;
                set;
            }
            public double Myinvnum
            {
                get;
                set;
            }
            public double Mystdprice
            {
                get;
                set;
            }
            public double Mysellprice
            {
                get;
                set;
            }
            public string Myclino
            {
                get;
                set;
            }
            public string Myinvbywho
            {
                get;
                set;
            }
            public string Mymdno
            {
                get;
                set;
            }
        }
        public struct Uploadkcmainstruct
        {
            public string Mylistnomain
            {
                get;
                set;
            }
            public string Myclinomain
            {
                get;
                set;
            }
            public string Myclinozymain
            {
                get;
                set;
            }
            public int Mynowstatusmain
            {
                get;
                set;
            }
        }
        public struct Uploadkcsubstruct
        {
            public string Mylnumno
            {
                get;
                set;
            }
            public string Myprodno
            {
                get;
                set;
            }
            public double Mystdprice
            {
                get;
                set;
            }
            public double Myinvnum
            {
                get;
                set;
            }
            public DateTime Mydepdate
            {
                get;
                set;
            }
            public double Mylestnum
            {
                get;
                set;
            }
            public double Mylnum
            {
                get;
                set;
            }
            public int theblongto
            {
                get;
                set;
            }
        }
        public struct Uploadret2substruct
        {
            public string Mylnumno
            {
                get;
                set;
            }
            public string Myprodno
            {
                get;
                set;
            }
            public string Myprodadd
            {
                get;
                set;
            }
            public string Mybatchno
            {
                get;
                set;
            }
            public double Myretnum
            {
                get;
                set;
            }
            public double Mybuyprice
            {
                get;
                set;
            }
            public double Mystdprice
            {
                get;
                set;
            }
            public int theblongto
            {
                get;
                set;
            }
        }

        public struct Uploadthegjdmaindcver2struct
        {
            public string Mylistnomain
            {
                get;
                set;
            }
            public string Myclinomain
            {
                get;
                set;
            }
            public string Myclinozymain
            {
                get;
                set;
            }
            public DateTime Mylocaltimemain
            {
                get;
                set;
            }
            public int Mynowstatusmain
            {
                get;
                set;
            }
        }

        public struct Uploadthegjdmainstruct
        {
            public string Mylistnomain
            {
                get;
                set;
            }
            public string Myclinomain
            {
                get;
                set;
            }
            public DateTime Mylocaltimemain
            {
                get;
                set;
            }
            public int Mybelongtomain
            {
                get;
                set;
            }
            public int Mynowstatusmain
            {
                get;
                set;
            }
        }

        public struct Uploadthegjdsubstruct
        {
            public string Mylistnosub
            {
                get;
                set;
            }
            public string Myprodnosub
            {
                get;
                set;
            }
            public double Myneednumsub
            {
                get;
                set;
            }
            public int Mystatusub
            {
                get;
                set;
            }
            public DateTime Mylesttimesub
            {
                get;
                set;
            }
        }

        public struct Uploadthegjdsubver2struct
        {
            public string Mylistnosub
            {
                get;
                set;
            }
            public string Myprodnosub
            {
                get;
                set;
            }
            public string Myprodnamesub
            {
                get;
                set;
            }
            public string Mylastaddsub
            {
                get;
                set;
            }
            public double Myneednumsub
            {
                get;
                set;
            }
            public int Mystatusub
            {
                get;
                set;
            }
            public DateTime Mylesttimesub
            {
                get;
                set;
            }
            public int Mybelong
            {
                get;
                set;
            }
            public int Myreason
            {
                get;
                set;
            }
        }

        public struct Invfullinfostr
        {
           
            public string listno
            {
                get;
                set;
            }
         
            public DateTime invdate
            {
                get;
                set;
            }
          
            public string prodno
            {
                get;
                set;
            }

         
            public string prodname
            {
                get;
                set;
            }

        
            public string prodsize
            {
                get;
                set;
            }
          
            public string prodadd
            {
                get;
                set;
            }
          
            public string monad
            {
                get;
                set;
            }
    
            public string batchno
            {
                get;
                set;
            }
          
            public DateTime availdate
            {
                get;
                set;
            }
          
            public double invnum
            {
                get;
                set;
            }
          
            public double sellprice
            {
                get;
                set;
            }
          
            public double retailprice
            {
                get;
                set;
            }

         
            public string prodpzwh
            {
                get;
                set;
            }
        }

        public struct querypostinfo
        {
          
            public DateTime begtime { get; set; }

          
            public DateTime endtime { get; set; }

       
            public string cli_no { get; set; }

         
            public int thebelong { get; set; }

           
            public int pageSize { get; set; }

           
            public int pageIndex { get; set; }
        }

        public struct lestmodelstr
        {
         
            public string prodno { get; set; }
          
            public string prodname { get; set; }
        
            public string prodsize { get; set; }
       
            public string monad { get; set; }
        
            public string batchno { get; set; }
           
            public string prodadd { get; set; }
          
            public double lestnum { get; set; }
         
            public DateTime availdate { get; set; }

        }

        public struct MyInvSubStruct2
        {
            public string Myinvsubprodno
            {
                get;
                set;
            }
            public string Myinvsubprodname
            {
                get;
                set;
            }
            public string Myinvsubprodsize
            {
                get;
                set;
            }
            public string Myinvsubmonad
            {
                get;
                set;
            }
            public string Myinvsubboxnum
            {
                get;
                set;
            }
            public string Myinvsubwareno
            {
                get;
                set;
            }
            public string Myinvsubprodadd
            {
                get;
                set;
            }
            public string Myinvsubbatchno
            {
                get;
                set;
            }
            public double Myinvsubinvnum
            {
                get;
                set;
            }
            public double Myinvsubstdprice
            {
                get;
                set;
            }
            public double Myinvsubsellprice
            {
                get;
                set;
            }
            public DateTime Myinvsubavaildate
            {
                get;
                set;
            }
            public double Myinvsubretailprice
            {
                get;
                set;
            }
            public string Myinvsubprodmade
            {
                get;
                set;
            }
            public string Myinvsubprodlabel
            {
                get;
                set;
            }
            public string Myinvsubprodpzwh
            {
                get;
                set;
            }
            public string Myinvsubboxmidnum
            {
                get;
                set;
            }
            public string Myinvsubbarcode
            {
                get;
                set;
            }

            public DateTime Myproducedate
            {
                get;
                set;
            }
        }


    
}
