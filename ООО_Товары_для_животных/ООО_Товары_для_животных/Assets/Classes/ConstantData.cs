using System;
using System.Collections.Generic;
using System.Text;

namespace ООО_Товары_для_животных.Assets.Classes
{
    class ConstantData
    {
        public static MySql.Data.MySqlClient.MySqlConnection con =
            new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user=root;port=3306;pwd=ELINA2030;database=trade203");
    }
}
