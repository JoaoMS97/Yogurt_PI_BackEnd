﻿namespace Yogurt.Dto.Comment
{
    public class InputCommunityDto
    {
        public Guid IdCriador { get; set; }

        public Guid IdCategoria { get; set; }

        public string? Nome { get; set; }

        public string? Legenda { get; set; }

        public Byte[]? FotoComunidade { get; set; }
    }
}
