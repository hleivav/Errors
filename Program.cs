// See https://aka.ms/new-console-template for more information

using Errors;

List<UserError> errorList = new List<UserError>(); 

NumericInputError nie1 = new NumericInputError("534");
NumericInputError nie2 = new NumericInputError("333");
NumericInputError nie3 = new NumericInputError("4423"); 
errorList.Add(nie1);
errorList.Add(nie2);    
errorList.Add(nie3);
TextInputError tie1 = new TextInputError("femhundratrettiofyra"); 
TextInputError tie2 = new TextInputError("trehundratrettiotre");
TextInputError tie3 = new TextInputError("fyratusenfyrahundratjugotre");
errorList.Add(tie1);
errorList.Add(tie2);    
errorList.Add(tie3);
HumanError hie1 = new HumanError("WTF");
errorList.Add(hie1);
ExtraterrestrialError ete1 = new ExtraterrestrialError("oh boy!"); 
errorList.Add(ete1);
HumorError he1 = new HumorError("Boring!");
errorList.Add(he1);

foreach (UserError error in errorList)
{
    Console.WriteLine(error.UEMessage());
}

