﻿using System.Collections.Generic;

using Federation.UWP.Objects.Game;

namespace Federation.UWP.DAL.Base
{
    public abstract class BaseDAL
    {
        public abstract IEnumerable<MainGameItem> GetGameList();

        public abstract bool SaveGame(MainGameItem gameItem);

        public abstract bool DeleteGame(MainGameItem gameItem);

        public abstract bool OverwriteGame(MainGameItem gameItem);
    }
}