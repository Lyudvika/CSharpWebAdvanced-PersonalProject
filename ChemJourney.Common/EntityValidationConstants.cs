using System.Data;

namespace ChemJourney.Common
{
    public static class EntityValidationConstants
    {
        public static class Element
        {
            public const int NameMaxLength = 20;

            public const int SymbolMaxLength = 2;

            public const int StandardStateMaxLength = 10;

            public const int OxidationStatesStateMaxLength = 30;
        }

        public static class Category
        {
            public const int NameMaxLength = 30;
        }

        public static class ChemicalGroupBlock
        {
            public const int NameMaxLength = 30;
        }

        public static class Post
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 5;

            public const int ContentMaxLength = 300;
            public const int ContentMinLength = 20;
        }

        public static class PostReply
        {
            public const int ContentMaxLength = 150;
            public const int ContentMinLength = 20;
        }

        public static class DateTimeFormat
        {
            public const string DateFormat = "dd/MM/yyyy HH:mm";
        }
    }
}
