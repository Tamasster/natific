var tinyWarehouse = tinyWarehouse || {};

tinyWarehouse.partsViewModel = function () {
    var self = this;

    self.parts = tinyWarehouse.repositories.dataRepo.parts;
    self.loading = tinyWarehouse.repositories.stateRepo.isPartsLoading;

    let loadParts = function () {
        let resp = JSON.parse(this.response);

        if (resp.length > 0) {
            let model = tinyWarehouse.dataModel;

            for (var i = 0; i < resp.length; i++) {
                self.parts.push(
                    new model.part(resp[i].PartNumber, resp[i].Name, resp[i].Description, resp[i].Price, resp[i].Weight)
                );
            }
        }

        self.loading(false);
    }

    let errorHandler = function () {
        self.loading(false);
    }

    let loadReq = new XMLHttpRequest();
    loadReq.addEventListener("load", loadParts);
    loadReq.addEventListener("error", errorHandler);
    loadReq.addEventListener("abort", errorHandler);
    loadReq.open("GET", window.location.origin + "/inventory/GetParts");
    loadReq.send();
    self.loading(true);
};

ko.applyBindings(new tinyWarehouse.partsViewModel());