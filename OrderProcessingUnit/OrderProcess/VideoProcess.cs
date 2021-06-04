using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.OrderProcess
{
    public class VideoProcess : IProcess
    {
        public string VideoName { get; private set; }

        public VideoProcess(string name)
        {
            this.VideoName = name;
        }

        public void process()
        {
            Console.WriteLine("add a free “First Aid” video to the packing slip(the result of a court decision in 1997");
        }

        IList<string> IProcess.process()
        {
            throw new NotImplementedException();
        }
    }
}
