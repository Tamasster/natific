var tinyWarehouse = tinyWarehouse || {};
tinyWarehouse.dataModel = {};

tinyWarehouse.dataModel.part = function (partNumber, name, description, price, weight) {
    this.PartNumber = partNumber;
    this.Name = name;
    this.Description = description;
    this.Price = price;
    this.Weight = weight;
};

tinyWarehouse.dataModel.inventoryItem = function (partNumber, name, description, price, weight, quantity) {
    tinyWarehouse.dataModel.part.call(this, partNumber, name, description, price, weight);   
    this.Quantity = quantity;
};

tinyWarehouse.dataModel.statistics = function (hasMost, priceSum, weightest, weightSum) {
    this.HasMost = hasMost;
    this.PriceSum = priceSum;
    this.Weightest = weightest;
    this.WeightSum = weightSum;
};