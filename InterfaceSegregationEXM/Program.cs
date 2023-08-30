using InterfaceSegregationEXM.UsingISP;

AllInOneDevice _AllInOneDevice = new();
_AllInOneDevice.Print();
_AllInOneDevice.Fax();
_AllInOneDevice.Scan();


OldPrinter _OldPrinter = new();
_OldPrinter.Print();
