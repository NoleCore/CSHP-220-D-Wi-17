using FlagsDB;
using System.Collections.Generic;
using System.Linq;

namespace FlagRepository
{
    public class FlagModel
    {
        public int ItemNum { get; set; }
        public string Description { get; set; }
        public double PricePerItem { get; set; }
        public int Quantity { get; set; }
        public double OurCost { get; set; }
        public double Value { get; set; }
        
    }

    public class FlagRepository
    {
        public FlagModel Add(FlagModel flagModel)
        {
            var flagsDb = ToDbModel(flagModel);

            DatabaseManager.Instance.Flags.Add(flagsDb);
            DatabaseManager.Instance.SaveChanges();

            flagModel = new FlagModel
            {
                ItemNum = flagsDb.ItemNum,
                Description = flagsDb.Description,
                PricePerItem = flagsDb.PricePerItem,
                Quantity = flagsDb.Quantity,
                OurCost = flagsDb.OurCost,
                Value = flagsDb.Value,
            };
            return flagModel;
        }

        public List<FlagModel> GetAll()
        {
            // Use .Select() to map the database contacts to ContactModel
            var items = DatabaseManager.Instance.Flags
              .Select(t => new FlagModel
              {
                  ItemNum = t.ItemNum,
                  Description = t.Description,
                  PricePerItem = t.PricePerItem,
                  Quantity = t.Quantity,
                  OurCost = t.OurCost,
                  Value = t.Value,
              }).ToList();

            return items;
        }

        public bool Update(FlagModel flagModel)
        {
            var original = DatabaseManager.Instance.Flags.Find(flagModel.ItemNum);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(flagModel));
                DatabaseManager.Instance.SaveChanges();
            }

            return false;
        }

        public bool Remove(int itemNum)
        {
            var items = DatabaseManager.Instance.Flags
                                .Where(t => t.ItemNum == itemNum);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Flags.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        private Flag ToDbModel(FlagModel flagModel)
        {
            var flagsDb = new Flag
            {
                ItemNum = flagModel.ItemNum,
                Description = flagModel.Description,
                PricePerItem = flagModel.PricePerItem,
                Quantity = flagModel.Quantity,
                OurCost = flagModel.OurCost,
                Value = flagModel.Value,
            };

            return flagsDb;
        }
    }
}
