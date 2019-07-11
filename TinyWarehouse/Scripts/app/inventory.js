var tinyWarehouse = tinyWarehouse || {};

tinyWarehouse.inventoryViewModel = function () {
    let self = this;
    self.inventory = tinyWarehouse.repositories.dataRepo.inventory;
    self.inventoryLoading = tinyWarehouse.repositories.stateRepo.isInvetoryLoading;

    let loadInventory = function() {
         let resp = JSON.parse(this.response);

        if (resp.length > 0) {
            let model = tinyWarehouse.dataModel;

            for (var i = 0; i < resp.length; i++) {
                self.inventory.push(
                    new model.inventoryItem(resp[i].PartNumber, resp[i].Name, resp[i].Description, resp[i].Price, resp[i].Weight, resp[i].Quantity)
                );
            }
        }

        self.inventoryLoading(false);
    }

    let errorHandler = function () {
        self.inventoryLoading(false);
    }

    let loadReq = new XMLHttpRequest();
    loadReq.addEventListener("load", loadInventory);
    loadReq.addEventListener("error", errorHandler);
    loadReq.addEventListener("abort", errorHandler);
    loadReq.open("GET", window.location.origin + "/inventory/fullinventory");
    loadReq.send();
    self.inventoryLoading(true);

};

ko.applyBindings(new tinyWarehouse.inventoryViewModel());