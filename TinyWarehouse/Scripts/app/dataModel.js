var tinyWarehouse = tinyWarehouse || {};
tinyWarehouse.dataModel = {};

tinyWarehouse.dataModel.inventoryItem = function (partNumber, name, description, price, weight, quantity) {

    this.PartNumber = partNumber;
    this.Name = name;
    this.Description = description;
    this.Price = price;
    this.Weight = weight;
    this.Quantity = quantity;

};