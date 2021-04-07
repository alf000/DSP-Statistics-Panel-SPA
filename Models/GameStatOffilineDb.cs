using System.Collections.Generic;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.JSInterop;

namespace DSP_Statistics_Panel_SPA.Models
{


    public class GameStatOfflineDb : IndexedDbDatabaseModel
    {
        public GameStatOfflineDb()
        {
            Name = "GameStatData";
            Version = 1;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<GameStat>();
        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,
        };

    }







    public class GameStat
    {
        public string FactoryName { get; set; }
        public double TimeElapsed { get; set; }
        public int[] ResponseItemsIds { get; set; }
        public int[] ResponseItemsCounts { get; set; }
    }

}