using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul3_1302200040
{
    class KodePos
    {
        public int getKodePos(string Kel)
        {
            if (Kel == "Batununggal")
            {
                return 40266;
            }
            else if (Kel == "Kujangsari")
            {
                return 40287;
            }
            else if (Kel == "Mengger")
            {
                return 40267;
            }
            else if (Kel == "Wates")
            {
                return 40256;
            }
            else if (Kel == "Cijaura")
            {
                return 40287;
            }
            else if (Kel == "Jatisari")
            {
                return 40286;
            }
            else if (Kel == "Margasari")
            {
                return 40286;
            }
            else if (Kel == "Sekejati")
            {
                return 40286;
            }
            else if (Kel == "Kebonwaru")
            {
                return 40272;
            }
            else if (Kel == "Maleer")
            {
                return 40274;
            }
            else if (Kel == "Samoja")
            {
                return 40273;
            }
            else
            {
                return 0;
            }
        }
    }
}
