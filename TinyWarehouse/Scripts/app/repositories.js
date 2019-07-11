var tinyWarehouse = tinyWarehouse || {};
tinyWarehouse.repositories = {};

tinyWarehouse.repositories.stateRepo = {
    isInvetoryLoading: ko.observable(false),
    isPartsLoading: ko.observable(false),
    isStatisticsLoading: ko.observable(false)
};

tinyWarehouse.repositories.dataRepo = {
    inventory: ko.observableArray([]),
    parts: ko.observableArray([]),
    statistics: ko.observable()
}