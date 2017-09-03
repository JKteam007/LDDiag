using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Repository.Hierarchy;
using log4net.Layout;
using log4net.Appender;
using log4net.Core;

namespace LDDiag
{
    class Logger
    {
        public static void Setup()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender LDDiag = new RollingFileAppender();
            LDDiag.Name = "LDDiag";
            LDDiag.AppendToFile = true;
            LDDiag.File = @"Logs\lddiag.log";
            LDDiag.Layout = patternLayout;
            LDDiag.MaxSizeRollBackups = 5;
            LDDiag.MaximumFileSize = "20MB";
            LDDiag.RollingStyle = RollingFileAppender.RollingMode.Size;
            LDDiag.StaticLogFileName = true;
            LDDiag.ActivateOptions();
            hierarchy.Root.AddAppender(LDDiag);

            RollingFileAppender roller = new RollingFileAppender();
            roller.Name = "roller";
            roller.AppendToFile = true;
            roller.File = @"Logs\lddiag.log";
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = 5;
            roller.MaximumFileSize = "20MB";
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.StaticLogFileName = true;
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);


            MemoryAppender memory = new MemoryAppender();
            memory.ActivateOptions();
            hierarchy.Root.AddAppender(memory);

            hierarchy.Root.Level = Level.Debug;
            hierarchy.Configured = true;
        }
    }
}
