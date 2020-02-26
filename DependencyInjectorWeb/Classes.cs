using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjectorWeb
{
    public interface ILevelRepository
    {
        void FetchNextLevel();
    }

    public interface ILog
    {
        void WriteLog(string s);
    }
    class Log : ILog
    {
        public void WriteLog(string s)
        {

        }
    }

    class FileHandler : ILevelRepository
    {
        private readonly ILog logger;

        public FileHandler(ILog logger)
        {
            this.logger = logger;
        }
        public void FetchNextLevel()
        {
            logger.WriteLog("Nu hämtas new level i fil");
            //fwetch.---
        }
    }
    class DatabaseHandler : ILevelRepository
    {
        public void FetchNextLevel() { }
    }

    public interface IHighScoreSaveService
    {
        void Save(int points);
    }
    class HighScoreDatabaseService : IHighScoreSaveService
    {
        public void Save(int points)
        {
            //throw new NotImplementedException();
        }


    }

    class Spel
    {
        private ILevelRepository levelRepository;
        private readonly IHighScoreSaveService high;

        public Spel(ILevelRepository lev, IHighScoreSaveService high)
        {
            levelRepository = lev;
            this.high = high;
        }
        public void GameLoop()
        {
            levelRepository.FetchNextLevel();
            int highscore = 99;
            high.Save(highscore);
        }
    }


}