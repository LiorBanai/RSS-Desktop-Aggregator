using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregator.Util
{
  public   class EncodingsCodes
    {
      public sealed class DisplayItem<T>
      {
          public string DisplayName { get; private set; }
          public string Name { get; private set; }
          public string FullName { get { return DisplayName + " : " + Name; } }
          public T Value { get; private set; }


          internal DisplayItem(T encodingValue, string encodingDisplayName, string encodingName)
          {
              DisplayName = encodingDisplayName;
              Name = encodingName;
              Value = encodingValue;
          }

      }

      public static List<DisplayItem<int>> EncodingsCodeList { get; private set; }

       static EncodingsCodes()
      {
          EncodingsCodeList = new List<DisplayItem<int>>
                                  {
                                      new DisplayItem<int>(37, "IBM EBCDIC (US-Canada)", "IBM037"),
                                      new DisplayItem<int>(437, "OEM United States", "IBM437"),
                                      new DisplayItem<int>(500, "IBM EBCDIC (International)", "IBM500"),
                                      new DisplayItem<int>(708, "Arabic (ASMO 708)", "ASMO-708"),
                                      new DisplayItem<int>(720, "Arabic (DOS)", "DOS-720"),
                                      new DisplayItem<int>(737, "Greek (DOS)", "ibm737"),
                                      new DisplayItem<int>(775, "Baltic (DOS)", "ibm775"),
                                      new DisplayItem<int>(850, "Western European (DOS)", "ibm850"),
                                      new DisplayItem<int>(852, "Central European (DOS)", "ibm852"),
                                      new DisplayItem<int>(855, "OEM Cyrillic", "IBM855"),
                                      new DisplayItem<int>(857, "Turkish (DOS)", "ibm857"),
                                      new DisplayItem<int>(858, "OEM Multilingual Latin I", "IBM00858"),
                                      new DisplayItem<int>(860, "Portuguese (DOS)", "IBM860"),
                                      new DisplayItem<int>(861, "Icelandic (DOS)", "ibm861"),
                                      new DisplayItem<int>(862, "Hebrew (DOS)", "DOS-862"),
                                      new DisplayItem<int>(863, "French Canadian (DOS)", "IBM863"),
                                      new DisplayItem<int>(864, "Arabic (864)", "IBM864"),
                                      new DisplayItem<int>(865, "Nordic (DOS)", "IBM865"),
                                      new DisplayItem<int>(866, "Cyrillic (DOS)", "cp866"),
                                      new DisplayItem<int>(869, "Greek, Modern (DOS)", "ibm869"),
                                      new DisplayItem<int>(870, "IBM EBCDIC (Multilingual Latin-2)", "IBM870"),
                                      new DisplayItem<int>(874, "Thai (Windows)", "windows-874"),
                                      new DisplayItem<int>(875, "IBM EBCDIC (Greek Modern)", "cp875"),
                                      new DisplayItem<int>(932, "Japanese (Shift-JIS)", "shift_jis"),
                                      new DisplayItem<int>(936, "Chinese Simplified (GB2312)", "gb2312"),
                                      new DisplayItem<int>(949, "Korean", "ks_c_5601-1987"),
                                      new DisplayItem<int>(950, "Chinese Traditional (Big5)", "big5"),
                                      new DisplayItem<int>(1026, "IBM EBCDIC (Turkish Latin-5)", "IBM1026"),
                                      new DisplayItem<int>(1047, "IBM Latin-1", "IBM01047"),
                                      new DisplayItem<int>(1140, "IBM EBCDIC (US-Canada-Euro)", "IBM01140"),
                                      new DisplayItem<int>(1141, "IBM EBCDIC (Germany-Euro)", "IBM01141"),
                                      new DisplayItem<int>(1142, "IBM EBCDIC (Denmark-Norway-Euro)", "IBM01142"),
                                      new DisplayItem<int>(1143, "IBM EBCDIC (Finland-Sweden-Euro)", "IBM01143"),
                                      new DisplayItem<int>(1144, "IBM EBCDIC (Italy-Euro)", "IBM01144"),
                                      new DisplayItem<int>(1145, "IBM EBCDIC (Spain-Euro)", "IBM01145"),
                                      new DisplayItem<int>(1146, "IBM EBCDIC (UK-Euro)", "IBM01146"),
                                      new DisplayItem<int>(1147, "IBM EBCDIC (France-Euro)", "IBM01147"),
                                      new DisplayItem<int>(1148, "IBM EBCDIC (International-Euro)", "IBM01148"),
                                      new DisplayItem<int>(1149, "IBM EBCDIC (Icelandic-Euro)", "IBM01149"),
                                      new DisplayItem<int>(1200, "Unicode", "utf-16"),
                                      new DisplayItem<int>(1201, "Unicode (Big endian)", "unicodeFFFE"),
                                      new DisplayItem<int>(1250, "Central European (Windows)", "windows-1250"),
                                      new DisplayItem<int>(1251, "Cyrillic (Windows)", "windows-1251"),
                                      new DisplayItem<int>(1252, "Western European (Windows)", "Windows-1252"),
                                      new DisplayItem<int>(1253, "Greek (Windows)", "windows-1253"),
                                      new DisplayItem<int>(1254, "Turkish (Windows)", "windows-1254"),
                                      new DisplayItem<int>(1255, "Hebrew (Windows)", "windows-1255"),
                                      new DisplayItem<int>(1256, "Arabic (Windows)", "windows-1256"),
                                      new DisplayItem<int>(1257, "Baltic (Windows)", "windows-1257"),
                                      new DisplayItem<int>(1258, "Vietnamese (Windows)", "windows-1258"),
                                      new DisplayItem<int>(1361, "Korean (Johab)", "Johab"),
                                      new DisplayItem<int>(10000, "Western European (Mac)", "macintosh"),
                                      new DisplayItem<int>(10001, "Japanese (Mac)", "x-mac-japanese"),
                                      new DisplayItem<int>(10002, "Chinese Traditional (Mac)", "x-mac-chinesetrad"),
                                      new DisplayItem<int>(10003, "Korean (Mac)", "x-mac-korean"),
                                      new DisplayItem<int>(10004, "Arabic (Mac)", "x-mac-arabic"),
                                      new DisplayItem<int>(10005, "Hebrew (Mac)", "x-mac-hebrew"),
                                      new DisplayItem<int>(10006, "Greek (Mac)", "x-mac-greek"),
                                      new DisplayItem<int>(10007, "Cyrillic (Mac)", "x-mac-cyrillic"),
                                      new DisplayItem<int>(10008, "Chinese Simplified (Mac)", "x-mac-chinesesimp"),
                                      new DisplayItem<int>(10010, "Romanian (Mac)", "x-mac-romanian"),
                                      new DisplayItem<int>(10017, "Ukrainian (Mac)", "x-mac-ukrainian"),
                                      new DisplayItem<int>(10021, "Thai (Mac)", "x-mac-thai"),
                                      new DisplayItem<int>(10029, "Central European (Mac)", "x-mac-ce"),
                                      new DisplayItem<int>(10079, "Icelandic (Mac)", "x-mac-icelandic"),
                                      new DisplayItem<int>(10081, "Turkish (Mac)", "x-mac-turkish"),
                                      new DisplayItem<int>(10082, "Croatian (Mac)", "x-mac-croatian"),
                                      new DisplayItem<int>(12000, "Unicode (UTF-32)", "utf-32"),
                                      new DisplayItem<int>(12001, "Unicode (UTF-32 Big endian)", "utf-32BE"),
                                      new DisplayItem<int>(20000, "Chinese Traditional (CNS)", "x-Chinese-CNS"),
                                      new DisplayItem<int>(20001, "TCA Taiwan", "x-cp20001"),
                                      new DisplayItem<int>(20002, "Chinese Traditional (Eten)", "x-Chinese-Eten"),
                                      new DisplayItem<int>(20003, "IBM5550 Taiwan", "x-cp20003"),
                                      new DisplayItem<int>(20004, "TeleText Taiwan", "x-cp20004"),
                                      new DisplayItem<int>(20005, "Wang Taiwan", "x-cp20005"),
                                      new DisplayItem<int>(20105, "Western European (IA5)", "x-IA5"),
                                      new DisplayItem<int>(20106, "German (IA5)", "x-IA5-German"),
                                      new DisplayItem<int>(20107, "Swedish (IA5)", "x-IA5-Swedish"),
                                      new DisplayItem<int>(20108, "Norwegian (IA5)", "x-IA5-Norwegian"),
                                      new DisplayItem<int>(20127, "US-ASCII", "us-ascii"),
                                      new DisplayItem<int>(20261, "T.61", "x-cp20261"),
                                      new DisplayItem<int>(20269, "ISO-6937", "x-cp20269"),
                                      new DisplayItem<int>(20273, "IBM EBCDIC (Germany)", "IBM273"),
                                      new DisplayItem<int>(20277, "IBM EBCDIC (Denmark-Norway)", "IBM277"),
                                      new DisplayItem<int>(20278, "IBM EBCDIC (Finland-Sweden)", "IBM278"),
                                      new DisplayItem<int>(20280, "IBM EBCDIC (Italy)", "IBM280"),
                                      new DisplayItem<int>(20284, "IBM EBCDIC (Spain)", "IBM284"),
                                      new DisplayItem<int>(20285, "IBM EBCDIC (UK)", "IBM285"),
                                      new DisplayItem<int>(20290, "IBM EBCDIC (Japanese katakana)", "IBM290"),
                                      new DisplayItem<int>(20297, "IBM EBCDIC (France)", "IBM297"),
                                      new DisplayItem<int>(20420, "IBM EBCDIC (Arabic)", "IBM420"),
                                      new DisplayItem<int>(20423, "IBM EBCDIC (Greek)", "IBM423"),
                                      new DisplayItem<int>(20424, "IBM EBCDIC (Hebrew)", "IBM424"),
                                      new DisplayItem<int>(20833, "IBM EBCDIC (Korean Extended)","x-EBCDIC-KoreanExtended"),
                                      new DisplayItem<int>(20838, "IBM EBCDIC (Thai)", "IBM-Thai"),
                                      new DisplayItem<int>(20866, "Cyrillic (KOI8-R)", "koi8-r"),
                                      new DisplayItem<int>(20871, "IBM EBCDIC (Icelandic)", "IBM871"),
                                      new DisplayItem<int>(20880, "IBM EBCDIC (Cyrillic Russian)", "IBM880"),
                                      new DisplayItem<int>(20905, "IBM EBCDIC (Turkish)", "IBM905"),
                                      new DisplayItem<int>(20924, "IBM Latin-1", "IBM00924"),
                                      new DisplayItem<int>(20932, "Japanese (JIS 0208-1990 and 0212-1990)", "EUC-JP"),
                                      new DisplayItem<int>(20936, "Chinese Simplified (GB2312-80)", "x-cp20936"),
                                      new DisplayItem<int>(20949, "Korean Wansung", "x-cp20949"),
                                      new DisplayItem<int>(21025, "IBM EBCDIC (Cyrillic Serbian-Bulgarian)", "cp1025"),
                                      new DisplayItem<int>(21866, "Cyrillic (KOI8-U)", "koi8-u"),
                                      new DisplayItem<int>(28591, "Western European (ISO)", "iso-8859-1"),
                                      new DisplayItem<int>(28592, "Central European (ISO)", "iso-8859-2"),
                                      new DisplayItem<int>(28593, "Latin 3 (ISO)", "iso-8859-3"),
                                      new DisplayItem<int>(28594, "Baltic (ISO)", "iso-8859-4"),
                                      new DisplayItem<int>(28595, "Cyrillic (ISO)", "iso-8859-5"),
                                      new DisplayItem<int>(28596, "Arabic (ISO)", "iso-8859-6"),
                                      new DisplayItem<int>(28597, "Greek (ISO)", "iso-8859-7"),
                                      new DisplayItem<int>(28598, "Hebrew (ISO-Visual)", "iso-8859-8"),
                                      new DisplayItem<int>(28599, "Turkish (ISO)", "iso-8859-9"),
                                      new DisplayItem<int>(28603, "Estonian (ISO)", "iso-8859-13"),
                                      new DisplayItem<int>(28605, "Latin 9 (ISO)", "iso-8859-15"),
                                      new DisplayItem<int>(29001, "Europa", "x-Europa"),
                                      new DisplayItem<int>(38598, "Hebrew (ISO-Logical)", "iso-8859-8-i"),
                                      new DisplayItem<int>(50220, "Japanese (JIS)", "iso-2022-jp"),
                                      new DisplayItem<int>(50221, "Japanese (JIS-Allow 1 byte Kana)", "csISO2022JP"),
                                      new DisplayItem<int>(50222, "Japanese (JIS-Allow 1 byte Kana - SO/SI)","iso-2022-jp"),
                                      new DisplayItem<int>(50225, "Korean (ISO)", "iso-2022-kr"),
                                      new DisplayItem<int>(50227, "Chinese Simplified (ISO-2022)", "x-cp50227"),
                                      new DisplayItem<int>(51932, "Japanese (EUC)", "euc-jp"),
                                      new DisplayItem<int>(51936, "Chinese Simplified (EUC)", "EUC-CN"),
                                      new DisplayItem<int>(51949, "Korean (EUC)", "euc-kr"),
                                      new DisplayItem<int>(52936, "Chinese Simplified (HZ)", "hz-gb-2312"),
                                      new DisplayItem<int>(54936, "Chinese Simplified (GB18030)", "GB18030"),
                                      new DisplayItem<int>(57002, "ISCII Devanagari", "x-iscii-de"),
                                      new DisplayItem<int>(57003, "ISCII Bengali", "x-iscii-be"),
                                      new DisplayItem<int>(57004, "ISCII Tamil", "x-iscii-ta"),
                                      new DisplayItem<int>(57005, "ISCII Telugu", "x-iscii-te"),
                                      new DisplayItem<int>(57006, "ISCII Assamese", "x-iscii-as"),
                                      new DisplayItem<int>(57007, "ISCII Oriya", "x-iscii-or"),
                                      new DisplayItem<int>(57008, "ISCII Kannada", "x-iscii-ka"),
                                      new DisplayItem<int>(57009, "ISCII Malayalam", "x-iscii-ma"),
                                      new DisplayItem<int>(57010, "ISCII Gujarati", "x-iscii-gu"),
                                      new DisplayItem<int>(57011, "ISCII Punjabi", "x-iscii-pa"),
                                      new DisplayItem<int>(65000, "Unicode (UTF-7)", "utf-7"),
                                      new DisplayItem<int>(65001, "Unicode (UTF-8)", "utf-8")

                                  };

      }
    }
}
