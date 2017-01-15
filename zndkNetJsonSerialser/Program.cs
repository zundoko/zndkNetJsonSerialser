using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace zndkNetJsonSerialser
{
    class Program
    {
        static void Main(string[] args)
        {
            string               filepath = "../../zndkConf.json";

            string            json_string = File.ReadAllText(filepath);
            Console.WriteLine(json_string);

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(clszndkconf));
            MemoryStream               ms = new MemoryStream(Encoding.UTF8.GetBytes(json_string));
            clszndkconf              file = (clszndkconf)js.ReadObject(ms);
            zndkConf                 conf = file.conf;

            // parses a .json file
            {
                Console.WriteLine("==============================: file header");
                Console.WriteLine("@file   {0}", file.name  );
                Console.WriteLine("@brief  {0}", file.brief );
                Console.WriteLine("@note   {0}", file.note  );
                Console.WriteLine("@date   {0}", file.date  );
                Console.WriteLine("@author {0}", file.author);

                Console.WriteLine("==============================: zndk configuration");
                Console.WriteLine("ID      {0}", conf.ID    );
                Console.WriteLine("coeff   {0}", conf.coeff );
                Console.WriteLine("nsvr    {0}", conf.nsvr  );
                Console.WriteLine("==============================: zndk configuration > svr");
                foreach (var svr in conf.tcp.Select((tcp, idx) => new { tcp, idx }))
                {
                    Console.WriteLine("------------------------------: zndk configuration > svr {0}", svr.idx);
                    Console.WriteLine("tcp server {0}: addr={1}", svr.idx, svr.tcp.addr);
                    Console.WriteLine("tcp server {0}: port={1}", svr.idx, svr.tcp.port);
                }
                Console.WriteLine("==============================: test conter");
                Console.WriteLine("cnt     {0}", file.cnt   );
            }

            // updating the .json file
            {
                file.cnt++;
                FileStream                 fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                {
                    js.WriteObject(fs, file);
                }
                fs.Close();
            }

            Console.WriteLine("done");
#if DEBUG
            Console.WriteLine("Press ANY key to continue...");
            Console.ReadKey();
#endif
        }
    }
}
