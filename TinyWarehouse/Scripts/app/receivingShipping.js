var tinyWarehouse = tinyWarehouse || {};

tinyWarehouse.receivingShippingViewModel = function () {
    let self = this;

    // true = receiving , false = shipping
    self.transaction = ko.observable(true);


};