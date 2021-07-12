﻿using System.Collections.Generic;

namespace RestWithASPNETUdemy.Data.Converter.Contract
{
    public interface IParser<Origin, Destiny>
    {
        Destiny Parse(Origin origin);
        List<Destiny> Parse(List<Origin> origin);
    }
}
