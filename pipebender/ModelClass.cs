using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pipebender
{
    class ModelClass
    {
        int id, x, y, type;
        
        public void openFile(ComponentTable ct,StreamReader sr)
        {
            String s;

            //first process all components
            s = sr.ReadLine(); s = sr.ReadLine();
            while (s != "pipes")
            {
                String[] tokens = s.Split();
                
                type = Convert.ToInt32(tokens[0]);

                switch (type)
                {
                    case (int)EnumTypes.Pump:
                        createPump(ct,tokens);
                        break;
                    case (int)EnumTypes.Sink:
                        createSink(ct, tokens);
                        break;
                    case (int)EnumTypes.Merger:
                        break;
                    case (int)EnumTypes.Normal:
                        break;
                    case (int)EnumTypes.Regulable:
                        break;
                }
             s = sr.ReadLine();
            }

        }

        public void saveFile(ComponentTable ct, StreamWriter sw)
        {
            sw.WriteLine("components");
            foreach(Component c in ct.CompList)
            {
                sw.WriteLine(c.giveMeYourValuesInText());
            }
            sw.WriteLine("pipes");
        }
        private void createPump(ComponentTable ct, String[] tokens)
        {
            id = Convert.ToInt32(tokens[1]);
            x = Convert.ToInt32(tokens[2]);
            y = Convert.ToInt32(tokens[3]);
            int f = Convert.ToInt32(tokens[4]);
            int isOutAvail = Convert.ToInt32(tokens[5]);
            Point p = new Point(x, y);
            Pump pump = new Pump(id, p, type);
            ct.CompList.Add(pump);
            pump.Flow = f;
            pump.IsOutAvailable = isOutAvail;
        }

        private void createSink(ComponentTable ct, String[] tokens)
        {
            id = Convert.ToInt32(tokens[1]);
            x = Convert.ToInt32(tokens[2]);
            y = Convert.ToInt32(tokens[3]);
            int f = Convert.ToInt32(tokens[4]);
            Point p = new Point(x, y);
            Sink sink = new Sink(id, p,0, type);
            ct.CompList.Add(sink);
        }
    }
}
