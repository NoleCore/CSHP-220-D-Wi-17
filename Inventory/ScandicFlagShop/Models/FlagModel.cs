using System;

namespace ScandicFlagShop.Models
{
    public class FlagModel
    {
        public int ItemNum { get; set; }
        public string Description { get; set; }
        public double PricePerItem { get; set; }
        public int Quantity { get; set; }
        public double OurCost { get; set; }
        public double Value { get; set; }

        internal FlagModel Clone()
        {
            return (FlagModel)MemberwiseClone();
        }

        public FlagRepository.FlagModel ToRepositoryModel()
        {
            var repositoryModel = new FlagRepository.FlagModel
            {
                ItemNum = ItemNum,              
                Description = Description,
                PricePerItem = PricePerItem,
                Quantity = Quantity,
                OurCost = OurCost,
                Value = Value,              
            };

            return repositoryModel;
        }

        public static FlagModel ToModel(FlagRepository.FlagModel respositoryModel)
        {
            var flagModel = new FlagModel
            {
                ItemNum = respositoryModel.ItemNum,               
                Description = respositoryModel.Description,
                PricePerItem = respositoryModel.PricePerItem,
                Quantity = respositoryModel.Quantity,
                OurCost = respositoryModel.OurCost,
                Value = respositoryModel.Value,
            };

            return flagModel;
        }
    }
}
