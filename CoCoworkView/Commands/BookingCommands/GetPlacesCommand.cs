using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetPlacesCommand : CommandBase
    {
        public GetPlacesCommand(BookingViewModel vm, PlaceService placeService)
        {
            var miniOffices = placeService.GetAll();

            foreach (var item in miniOffices)
            {
                vm.Places.Add(item);
            }
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
