﻿using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetMiniOfficesCommand : CommandBase
    {
        public GetMiniOfficesCommand(BookingViewModel vm, MiniOfficeService miniOfficeService)
        {
            var miniOffices = miniOfficeService.GetAll();

            foreach (var item in miniOffices)
            {
                vm.MiniOffices.Add(item);
            }
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}