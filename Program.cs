using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
var result = vm.AggregateCustomQuery();

// Display Results
vm.Display(result);