using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
var result = vm.AggregateQuery();

// Display Results
vm.Display(result);