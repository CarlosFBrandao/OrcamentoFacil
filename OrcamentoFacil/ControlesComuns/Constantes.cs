using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlesComuns
{
    public class Constantes
    {
        public const int CEP_LENGTH = 8;
        public const int CNPJ_LENGTH = 14;
        public const int CPF_LENGTH = 11;
        public const int CELULAR_LENGTH = 11;
        public const int TELEFONE_LENGTH = 10;
        public static Key[] KeysNavegacao = { Key.Left, Key.Right, Key.Up, Key.Down, Key.Back, Key.Delete };
    }
}
