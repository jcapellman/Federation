using System.Collections.Generic;
using System.IO;

using Windows.Storage;

using Federation.UWP.DAL.Base;
using Federation.UWP.Objects.Game;

using LiteDB;

namespace Federation.UWP.DAL
{
    public class LiteDBDAL : BaseDAL
    {
        private const string DbFileName = "Federation.db";

        private static string ConnectionString => Path.Combine(ApplicationData.Current.LocalFolder.Path, DbFileName);

        public override IEnumerable<MainGameItem> GetGameList()
        {
            using (var db = new LiteDatabase(ConnectionString))
            {
                return db.GetCollection<MainGameItem>().FindAll();
            }
        }

        public override bool SaveGame(MainGameItem gameItem)
        {
            using (var db = new LiteDatabase(ConnectionString))
            {
                var gameCollection = db.GetCollection<MainGameItem>();

                gameCollection.Insert(gameItem);
            }

            return true;
        }
    }
}