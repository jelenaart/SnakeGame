//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SnakeGame
//{
//    public class Params
//    {
//        private string resourceFolder;

//        public Params()
//        {
//            var ind = Directory.GetCurrentDirectory().ToString()
//                .IndexOf("bin", StringComparsion.Ordinal);//polu4it indeks papki bin

//            string binFolder =
//                Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString();
//            //put do ukazannoy v indekse papki

//            resourceFolder = binFolder + "resources\\";
//        }
//        public string GetResourceFolder()
//        {
//            return resourceFolder;
//        }
//    }
//}
