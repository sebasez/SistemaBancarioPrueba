﻿namespace SistemaBancario.Presenters
{
    public interface IPresenter<FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}