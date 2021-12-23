using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class DeleteBookingItemCommand : CommandBase
    {
        private BookingViewModel _vm;
        private MiniOfficeService _miniOfficeService;
        private RoomService _roomService;
        private ComputerService _computerService;
        private PlaceService _placeService;

        public DeleteBookingItemCommand(BookingViewModel vm, MiniOfficeService miniOfficeService,
            RoomService roomService, ComputerService computerService, PlaceService placeService)
        {
            _vm = vm;
            _miniOfficeService = miniOfficeService;
            _roomService = roomService;
            _computerService = computerService;
            _placeService = placeService;
        }

        public override void Execute(object parameter)
        {
            var selectedItem = _vm.BookingSelectedItem;

            if (selectedItem is null)
            {
                MessageBox.Show("Выберите элемент в таблице!");
            }
            else if (selectedItem is MiniOfficeModel)
            {
                MiniOfficeModel miniOffice = (MiniOfficeModel)selectedItem;
                _miniOfficeService.DeleteMiniOffice(miniOffice.Id);
                _vm.MiniOffices.Remove(miniOffice);
                MessageBox.Show("Выбранный миниофис успешно удален");
            }
            else if (selectedItem is PlaceModel)
            {
                PlaceModel place = (PlaceModel)selectedItem;
                _placeService.DeletePlace(place.Id);
                _vm.Places.Remove(place);
                MessageBox.Show("Выбранное место успешно удалено");
            }
            else if (selectedItem is RoomModel)
            {
                //RoomModel room = (RoomModel)selectedItem;
                //if (room.RoomType == )

                //    _placeService.DeletePlace(place.Id);
                //_vm.Places.Remove(place);
                //MessageBox.Show("Выбранное место успешно удалено!");
            }
        }
    }
}
