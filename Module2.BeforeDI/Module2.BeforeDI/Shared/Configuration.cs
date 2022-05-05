namespace Module2.BeforeDI.Shared;
public class Configuration
{
    // We will deal with passing in configuration in a better way in a future module
    // For now hardcoding the values is enough to practice with the concepts from this module

    public string SourceCsvPath => @"E:\dev\2022\05\pluralsight\c10dependinject\pl-dependInject\Module2.BeforeDI\Module2.BeforeDI\product-input.csv";
    public string TargetCsvPath => @"E:\dev\2022\05\pluralsight\c10dependinject\pl-dependInject\Module2.BeforeDI\Module2.BeforeDI\product-output.csv";
}