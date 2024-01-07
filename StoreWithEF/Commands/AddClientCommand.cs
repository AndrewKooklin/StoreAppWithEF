using StoreWithEF.HelpMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreWithEF.Commands
{
    public class AddClientCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        string lastNameValue = "";
        string firstNameValue = "";
        string fathersNameValue = "";
        string phoneNumberValue = "";
        string emailValue = "";

        public bool CanExecute(object parameter)
        {
            if(parameter is Grid)
            {
                Grid gridClient = (Grid)parameter;
                var gridChildren = gridClient.Children;
                TextBox lastName = (TextBox)gridChildren[6];
                TextBox firstName = (TextBox)gridChildren[8];
                TextBox fathersName = (TextBox)gridChildren[10];
                TextBox phoneNumber = (TextBox)gridChildren[12];
                TextBox email = (TextBox)gridChildren[14];

                Label lastNameError = (Label)gridChildren[7];
                Label firstNameError = (Label)gridChildren[9];
                Label fathersNameError = (Label)gridChildren[11];
                Label phoneNumberError = (Label)gridChildren[13];
                Label emailError = (Label)gridChildren[15];

                lastNameValue = lastName.Text.ToString();
                firstNameValue = firstName.Text.ToString();
                fathersNameValue = fathersName.Text.ToString();
                phoneNumberValue = phoneNumber.Text.ToString();
                emailValue = email.Text.ToString();

                CheckTextAddClientForm checkInputText = new CheckTextAddClientForm();

                if (!checkInputText.CheckName(lastNameValue))
                {
                    lastNameError.Content = "Фамилия не менее 3 букв";
                    return false;
                }
                else
                {
                    lastNameError.Content = "";
                }
                if (!checkInputText.CheckName(firstNameValue))
                {
                    firstNameError.Content = "Имя не менее 3 букв";
                    return false;
                }
                else
                {
                    firstNameError.Content = "";
                }
                if (!checkInputText.CheckName(fathersNameValue))
                {
                    fathersNameError.Content = "Отчество не менее 3 букв";
                    return false;
                }
                else
                {
                    fathersNameError.Content = "";
                }
                if (!checkInputText.CheckPhone(phoneNumberValue))
                {
                    phoneNumberError.Content = "Телефон 11 цифр";
                    return false;
                }
                else
                {
                    phoneNumberError.Content = "";
                }
                if (!checkInputText.CheckEmail(emailValue))
                {
                    emailError.Content = "Email в формате name@site.ru";
                    return false;
                }
                else
                {
                    emailError.Content = "";
                }
            }
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter != null)
            {
                Clients client = new Clients(lastNameValue, firstNameValue, fathersNameValue,
                    phoneNumberValue, emailValue);
                AddNewClient addNewClient = new AddNewClient();
                addNewClient.Add(client);
            }
        }
    }
}
