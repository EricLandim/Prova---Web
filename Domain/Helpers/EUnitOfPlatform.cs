using System.ComponentModel;

namespace api_rest.Domain.Helpers
{
    public enum EUnitOfMovie : byte
    {
        [Description("acao")]
        acao = 1,

        [Description("comédia")]
        comédia = 2,

        [Description("drama")]
        drama = 3,

    }

}
