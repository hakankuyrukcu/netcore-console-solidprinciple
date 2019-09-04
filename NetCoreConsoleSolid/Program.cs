using System;

namespace NetCoreConsoleSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region SR Example
            var addressVerifierSR = new SingleResponsibility.AddressVerifier();

            try
            {
                var account = new SingleResponsibility.Const.Account();
                account.Address = new SingleResponsibility.Const.Address();
                var employee = new SingleResponsibility.Const.EmployeeAccount();
                employee.Address = new SingleResponsibility.Const.Address();

                addressVerifierSR.IsAddressValid(account.Address, SingleResponsibility.Const.AddressTypeEnum.Customer);
                addressVerifierSR.IsAddressValid(employee.Address, SingleResponsibility.Const.AddressTypeEnum.Employee);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            #endregion

            #region OCP Example
            var stateFinder = new OpenClosed.Services.StateFinder();

            // For the Turkey
            try
            {
                var addressVerifierOCP = new OpenClosed.AddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(11, addressVerifierOCP));
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifierOCP));
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            // For the Azerbaijan
            try
            {
                var addressVerifierAzOCP = new OpenClosed.AzerbaijanAddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifierAzOCP));
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
            #endregion

            #region LSP Example
            try
            {
                var accountService = new LiskovsSubstitution.Services.AccountService();

                var addressServiceDB = new LiskovsSubstitution.Services.AddressService();
                var addressDB = addressServiceDB.GetAddressForUser(25);
                accountService.ChangeAddress(addressDB);

                var addressService = new LiskovsSubstitution.Services.NewAddressService();
                var address = addressService.GetAddressForUser(25);
                accountService.ChangeAddress(address);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            #endregion

            #region ISP Example
            try
            {
                var foodBank = new InterfaceSegregation.FoodBank();

                var human = new InterfaceSegregation.Const.Human();
                var animal = new InterfaceSegregation.Const.Animal();
                foodBank.AddToList(human);
                foodBank.AddToList(animal);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            #endregion

            #region DIP Example
            try
            {
                var accountCreator = new DependencyInversion.Services.AccountCreator(new DependencyInversion.Const.AccountRepository());
                accountCreator.SaveAccount(new DependencyInversion.Const.AccountModel() { FirstName = "Hakan", LastName = "Kuyrukcu" });
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            #endregion
        }
    }
}
