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
        IList<string> results;
        private readonly string _videoName;

        public VideoProcess(string videoName)
        {
            results = new List<string>();
            _videoName = videoName;
        }

        IList<string> IProcess.process()
        {
            Console.WriteLine("add a free “First Aid” video to the packing slip(the result of a court decision in 1997");
            results.Add(ProcessResult.Video_Result);
            return results;
        }

        public string GetVideoName()
        {
            return _videoName;
        }
    }
}
