using MessageLog.Interfaces;
using MessageLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLog
{
    internal class ManageProcessor
    {
        #fortementeacoplado
        /*private LogManager _logManager;
        public ManageProcessor() 
        {
            _logManager = new LogManager();
        }

        public void ProcessMessage(string message)
        {
            Console.WriteLine($"Processing message : {message}");
            _logManager.LogToFile($"Message processed. {DateTime.Now}. {message}");
            _logManager.LogToXml($"Message processed. {DateTime.Now}. {message}");

        }*/
        
        private readonly ILogger _logger;
        public ManageProcessor(ILogger logger) 
        {
            _logger = logger;
        }

        public void ProcessMessage(string message)
        {
            Console.WriteLine($"Processing message : {message}");
            _logger.Log($"Message processed : {DateTime.Now}. {message}");
        }
    }
}
