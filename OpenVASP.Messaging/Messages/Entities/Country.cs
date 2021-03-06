﻿using System.Collections.Generic;

namespace OpenVASP.Messaging.Messages.Entities
{
    public class Country
    {
        public string Name { get; private set; }
        public string TwoLetterCode { get; private set; }

        private Country(string name, string twoLetterCode)
        {
            Name = name;
            TwoLetterCode = twoLetterCode;
        }

        public override string ToString()
        {
            return TwoLetterCode;
        }

        public static readonly Dictionary<string, Country> List = new Dictionary<string, Country>()
        {
            {"AF" , new Country("Afghanistan", "AF")},
            {"AL" , new Country("Albania", "AL")},
            {"DZ" , new Country("Algeria", "DZ")},
            {"AS" , new Country("American Samoa", "AS")},
            {"AD" , new Country("Andorra", "AD")},
            {"AO" , new Country("Angola", "AO")},
            {"AI" , new Country("Anguilla", "AI")},
            {"AQ" , new Country("Antarctica", "AQ")},
            {"AG" , new Country("Antigua and Barbuda", "AG")},
            {"AR" , new Country("Argentina", "AR")},
            {"AM" , new Country("Armenia", "AM")},
            {"AW" , new Country("Aruba", "AW")},
            {"AU" , new Country("Australia", "AU")},
            {"AT" , new Country("Austria", "AT")},
            {"AZ" , new Country("Azerbaijan", "AZ")},
            {"BS" , new Country("Bahamas", "BS")},
            {"BH" , new Country("Bahrain", "BH")},
            {"BD" , new Country("Bangladesh", "BD")},
            {"BB" , new Country("Barbados", "BB")},
            {"BY" , new Country("Belarus", "BY")},
            {"BE" , new Country("Belgium", "BE")},
            {"BZ" , new Country("Belize", "BZ")},
            {"BJ" , new Country("Benin", "BJ")},
            {"BM" , new Country("Bermuda", "BM")},
            {"BT" , new Country("Bhutan", "BT")},
            {"BO" , new Country("Bolivia, Plurinational State of", "BO")},
            {"BQ" , new Country("Bonaire, Sint Eustatius and Saba", "BQ")},
            {"BA" , new Country("Bosnia and Herzegovina", "BA")},
            {"BW" , new Country("Botswana", "BW")},
            {"BV" , new Country("Bouvet Island", "BV")},
            {"BR" , new Country("Brazil", "BR")},
            {"IO" , new Country("British Indian Ocean Territory", "IO")},
            {"BN" , new Country("Brunei Darussalam", "BN")},
            {"BG" , new Country("Bulgaria", "BG")},
            {"BF" , new Country("Burkina Faso", "BF")},
            {"BI" , new Country("Burundi", "BI")},
            {"CV" , new Country("Cabo Verde", "CV")},
            {"KH" , new Country("Cambodia", "KH")},
            {"CM" , new Country("Cameroon", "CM")},
            {"CA" , new Country("Canada", "CA")},
            {"KY" , new Country("Cayman Islands", "KY")},
            {"CF" , new Country("Central African Republic", "CF")},
            {"TD" , new Country("Chad", "TD")},
            {"CL" , new Country("Chile", "CL")},
            {"CN" , new Country("China", "CN")},
            {"CX" , new Country("Christmas Island", "CX")},
            {"CC" , new Country("Cocos (Keeling) Islands", "CC")},
            {"CO" , new Country("Colombia", "CO")},
            {"KM" , new Country("Comoros", "KM")},
            {"CG" , new Country("Congo", "CG")},
            {"CD" , new Country("Congo, the Democratic Republic of the", "CD")},
            {"CK" , new Country("Cook Islands", "CK")},
            {"CR" , new Country("Costa Rica", "CR")},
            {"CI" , new Country("Côte d'Ivoire", "CI")},
            {"HR" , new Country("Croatia", "HR")},
            {"CU" , new Country("Cuba", "CU")},
            {"CW" , new Country("Curaçao", "CW")},
            {"CY" , new Country("Cyprus", "CY")},
            {"CZ" , new Country("Czechia", "CZ")},
            {"DK" , new Country("Denmark", "DK")},
            {"DJ" , new Country("Djibouti", "DJ")},
            {"DM" , new Country("Dominica", "DM")},
            {"DO" , new Country("Dominican Republic", "DO")},
            {"EC" , new Country("Ecuador", "EC")},
            {"EG" , new Country("Egypt", "EG")},
            {"SV" , new Country("El Salvador", "SV")},
            {"GQ" , new Country("Equatorial Guinea", "GQ")},
            {"ER" , new Country("Eritrea", "ER")},
            {"EE" , new Country("Estonia", "EE")},
            {"SZ" , new Country("Eswatini", "SZ")},
            {"ET" , new Country("Ethiopia", "ET")},
            {"FK" , new Country("Falkland Islands (Malvinas)", "FK")},
            {"FO" , new Country("Faroe Islands", "FO")},
            {"FJ" , new Country("Fiji", "FJ")},
            {"FI" , new Country("Finland", "FI")},
            {"FR" , new Country("France", "FR")},
            {"GF" , new Country("French Guiana", "GF")},
            {"PF" , new Country("French Polynesia", "PF")},
            {"TF" , new Country("French Southern Territories", "TF")},
            {"GA" , new Country("Gabon", "GA")},
            {"GM" , new Country("Gambia", "GM")},
            {"GE" , new Country("Georgia", "GE")},
            {"DE" , new Country("Germany", "DE")},
            {"GH" , new Country("Ghana", "GH")},
            {"GI" , new Country("Gibraltar", "GI")},
            {"GR" , new Country("Greece", "GR")},
            {"GL" , new Country("Greenland", "GL")},
            {"GD" , new Country("Grenada", "GD")},
            {"GP" , new Country("Guadeloupe", "GP")},
            {"GU" , new Country("Guam", "GU")},
            {"GT" , new Country("Guatemala", "GT")},
            {"GG" , new Country("Guernsey", "GG")},
            {"GN" , new Country("Guinea", "GN")},
            {"GW" , new Country("Guinea-Bissau", "GW")},
            {"GY" , new Country("Guyana", "GY")},
            {"HT" , new Country("Haiti", "HT")},
            {"HM" , new Country("Heard Island and McDonald Islands", "HM")},
            {"VA" , new Country("Holy See", "VA")},
            {"HN" , new Country("Honduras", "HN")},
            {"HK" , new Country("Hong Kong", "HK")},
            {"HU" , new Country("Hungary", "HU")},
            {"IS" , new Country("Iceland", "IS")},
            {"IN" , new Country("India", "IN")},
            {"ID" , new Country("Indonesia", "ID")},
            {"IR" , new Country("Iran, Islamic Republic of", "IR")},
            {"IQ" , new Country("Iraq", "IQ")},
            {"IE" , new Country("Ireland", "IE")},
            {"IM" , new Country("Isle of Man", "IM")},
            {"IL" , new Country("Israel", "IL")},
            {"IT" , new Country("Italy", "IT")},
            {"JM" , new Country("Jamaica", "JM")},
            {"JP" , new Country("Japan", "JP")},
            {"JE" , new Country("Jersey", "JE")},
            {"JO" , new Country("Jordan", "JO")},
            {"KZ" , new Country("Kazakhstan", "KZ")},
            {"KE" , new Country("Kenya", "KE")},
            {"KI" , new Country("Kiribati", "KI")},
            {"KP" , new Country("Korea, Democratic People's Republic of", "KP")},
            {"KR" , new Country("Korea, Republic of", "KR")},
            {"KW" , new Country("Kuwait", "KW")},
            {"KG" , new Country("Kyrgyzstan", "KG")},
            {"LA" , new Country("Lao People's Democratic Republic", "LA")},
            {"LV" , new Country("Latvia", "LV")},
            {"LB" , new Country("Lebanon", "LB")},
            {"LS" , new Country("Lesotho", "LS")},
            {"LR" , new Country("Liberia", "LR")},
            {"LY" , new Country("Libya", "LY")},
            {"LI" , new Country("Liechtenstein", "LI")},
            {"LT" , new Country("Lithuania", "LT")},
            {"LU" , new Country("Luxembourg", "LU")},
            {"MO" , new Country("Macao", "MO")},
            {"MG" , new Country("Madagascar", "MG")},
            {"MW" , new Country("Malawi", "MW")},
            {"MY" , new Country("Malaysia", "MY")},
            {"MV" , new Country("Maldives", "MV")},
            {"ML" , new Country("Mali", "ML")},
            {"MT" , new Country("Malta", "MT")},
            {"MH" , new Country("Marshall Islands", "MH")},
            {"MQ" , new Country("Martinique", "MQ")},
            {"MR" , new Country("Mauritania", "MR")},
            {"MU" , new Country("Mauritius", "MU")},
            {"YT" , new Country("Mayotte", "YT")},
            {"MX" , new Country("Mexico", "MX")},
            {"FM" , new Country("Micronesia, Federated States of", "FM")},
            {"MD" , new Country("Moldova, Republic of", "MD")},
            {"MC" , new Country("Monaco", "MC")},
            {"MN" , new Country("Mongolia", "MN")},
            {"ME" , new Country("Montenegro", "ME")},
            {"MS" , new Country("Montserrat", "MS")},
            {"MA" , new Country("Morocco", "MA")},
            {"MZ" , new Country("Mozambique", "MZ")},
            {"MM" , new Country("Myanmar", "MM")},
            {"NA" , new Country("Namibia", "NA")},
            {"NR" , new Country("Nauru", "NR")},
            {"NP" , new Country("Nepal", "NP")},
            {"NL" , new Country("Netherlands", "NL")},
            {"NC" , new Country("New Caledonia", "NC")},
            {"NZ" , new Country("New Zealand", "NZ")},
            {"NI" , new Country("Nicaragua", "NI")},
            {"NE" , new Country("Niger", "NE")},
            {"NG" , new Country("Nigeria", "NG")},
            {"NU" , new Country("Niue", "NU")},
            {"NF" , new Country("Norfolk Island", "NF")},
            {"MP" , new Country("Northern Mariana Islands", "MP")},
            {"MK" , new Country("North Macedonia", "MK")},
            {"NO" , new Country("Norway", "NO")},
            {"OM" , new Country("Oman", "OM")},
            {"PK" , new Country("Pakistan", "PK")},
            {"PW" , new Country("Palau", "PW")},
            {"PS" , new Country("Palestine, State of", "PS")},
            {"PA" , new Country("Panama", "PA")},
            {"PG" , new Country("Papua New Guinea", "PG")},
            {"PY" , new Country("Paraguay", "PY")},
            {"PE" , new Country("Peru", "PE")},
            {"PH" , new Country("Philippines", "PH")},
            {"PN" , new Country("Pitcairn", "PN")},
            {"PL" , new Country("Poland", "PL")},
            {"PT" , new Country("Portugal", "PT")},
            {"PR" , new Country("Puerto Rico", "PR")},
            {"QA" , new Country("Qatar", "QA")},
            {"RE" , new Country("Réunion", "RE")},
            {"RO" , new Country("Romania", "RO")},
            {"RU" , new Country("Russian Federation", "RU")},
            {"RW" , new Country("Rwanda", "RW")},
            {"BL" , new Country("Saint Barthélemy", "BL")},
            {"SH" , new Country("Saint Helena, Ascension and Tristan da Cunha", "SH")},
            {"KN" , new Country("Saint Kitts and Nevis", "KN")},
            {"LC" , new Country("Saint Lucia", "LC")},
            {"MF" , new Country("Saint Martin (French part)", "MF")},
            {"PM" , new Country("Saint Pierre and Miquelon", "PM")},
            {"VC" , new Country("Saint Vincent and the Grenadines", "VC")},
            {"WS" , new Country("Samoa", "WS")},
            {"SM" , new Country("San Marino", "SM")},
            {"ST" , new Country("Sao Tome and Principe", "ST")},
            {"SA" , new Country("Saudi Arabia", "SA")},
            {"SN" , new Country("Senegal", "SN")},
            {"RS" , new Country("Serbia", "RS")},
            {"SC" , new Country("Seychelles", "SC")},
            {"SL" , new Country("Sierra Leone", "SL")},
            {"SG" , new Country("Singapore", "SG")},
            {"SX" , new Country("Sint Maarten (Dutch part)", "SX")},
            {"SK" , new Country("Slovakia", "SK")},
            {"SI" , new Country("Slovenia", "SI")},
            {"SB" , new Country("Solomon Islands", "SB")},
            {"SO" , new Country("Somalia", "SO")},
            {"ZA" , new Country("South Africa", "ZA")},
            {"GS" , new Country("South Georgia and the South Sandwich Islands", "GS")},
            {"SS" , new Country("South Sudan", "SS")},
            {"ES" , new Country("Spain", "ES")},
            {"LK" , new Country("Sri Lanka", "LK")},
            {"SD" , new Country("Sudan", "SD")},
            {"SR" , new Country("Suriname", "SR")},
            {"SJ" , new Country("Svalbard and Jan Mayen", "SJ")},
            {"SE" , new Country("Sweden", "SE")},
            {"CH" , new Country("Switzerland", "CH")},
            {"SY" , new Country("Syrian Arab Republic", "SY")},
            {"TW" , new Country("Taiwan, Province of China", "TW")},
            {"TJ" , new Country("Tajikistan", "TJ")},
            {"TZ" , new Country("Tanzania, United Republic of", "TZ")},
            {"TH" , new Country("Thailand", "TH")},
            {"TL" , new Country("Timor-Leste", "TL")},
            {"TG" , new Country("Togo", "TG")},
            {"TK" , new Country("Tokelau", "TK")},
            {"TO" , new Country("Tonga", "TO")},
            {"TT" , new Country("Trinidad and Tobago", "TT")},
            {"TN" , new Country("Tunisia", "TN")},
            {"TR" , new Country("Turkey", "TR")},
            {"TM" , new Country("Turkmenistan", "TM")},
            {"TC" , new Country("Turks and Caicos Islands", "TC")},
            {"TV" , new Country("Tuvalu", "TV")},
            {"UG" , new Country("Uganda", "UG")},
            {"UA" , new Country("Ukraine", "UA")},
            {"AE" , new Country("United Arab Emirates", "AE")},
            {"GB" , new Country("United Kingdom of Great Britain and Northern Ireland", "GB")},
            {"US" , new Country("United States of America", "US")},
            {"UM" , new Country("United States Minor Outlying Islands", "UM")},
            {"UY" , new Country("Uruguay", "UY")},
            {"UZ" , new Country("Uzbekistan", "UZ")},
            {"VU" , new Country("Vanuatu", "VU")},
            {"VE" , new Country("Venezuela, Bolivarian Republic of", "VE")},
            {"VN" , new Country("Viet Nam", "VN")},
            {"VG" , new Country("Virgin Islands, British", "VG")},
            {"VI" , new Country("Virgin Islands, U.S.", "VI")},
            {"WF" , new Country("Wallis and Futuna", "WF")},
            {"EH" , new Country("Western Sahara", "EH")},
            {"YE" , new Country("Yemen", "YE")},
            {"ZM" , new Country("Zambia", "ZM")},
            {"ZW" , new Country("Zimbabwe", "ZW")},
            {"AX" , new Country("Åland Islands", "AX")}
        };
    }
}
