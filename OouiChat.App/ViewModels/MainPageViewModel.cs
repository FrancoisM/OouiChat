﻿using System;
using MvvmHelpers;
using OouiChat.App.Data;

namespace OouiChat.App.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        string username = "";
        public string Username {
            get => username;
            set => SetProperty (ref username, value);
        }
        string newMessage = "";
        public string NewMessage {
            get => newMessage;
            set => SetProperty (ref newMessage, value);
        }
        string roomName = "";
        public string RoomName {
            get => roomName;
            set => SetProperty (ref roomName, value);
        }
        string newRoomName = "";
        public string NewRoomName {
            get => newRoomName;
            set => SetProperty (ref newRoomName, value);
        }
        Exception error;
        public Exception Error {
            get => error;
            set => SetProperty (ref error, value, onChanged: () => OnPropertyChanged("ErrorIsVisible"));
        }
        public bool ErrorIsVisible => Error != null;

        public ObservableRangeCollection<ChatRoom> Rooms { get; } = new ObservableRangeCollection<ChatRoom> ();
        public ObservableRangeCollection<ChatUser> Users { get; } = new ObservableRangeCollection<ChatUser> ();
        public ObservableRangeCollection<ChatMessage> Messages { get; } = new ObservableRangeCollection<ChatMessage> ();
    }
}
