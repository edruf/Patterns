using System;
using System.Collections.Generic;
using System.Text;
using Builder.Builders;
using Builder.Directors;
using Patterns_Builder;
using Patterns_Builder.ComponentsOfBuilding;

namespace Facade
{
    internal class BuilderFacade
    {
        private DirectorFullButton _directorFullButton;
        private DirectorMinimalButton _directorMinimalButton;
        private DirectorCancelButton _directorCancelButton;
        private ButtonBuilder _buttonBuilder;
        private TextButtonBuilder _textButtonBuilder;

        public BuilderFacade()
        {
            _directorFullButton = new DirectorFullButton();
            _directorMinimalButton = new DirectorMinimalButton();
            _directorCancelButton = new DirectorCancelButton();
            _buttonBuilder = new ButtonBuilder();
            _textButtonBuilder = new TextButtonBuilder();
        }

        public Button CreateCancelButton() 
        {
            _directorCancelButton.Builder = _buttonBuilder;
            _directorCancelButton.BuildCancelButton();
            return _buttonBuilder.GetButton();
        }

        public Button CreateMinimalButton() 
        {
            _directorMinimalButton.Builder = _buttonBuilder;
            _directorMinimalButton.BuildMinimalButton();
            return _buttonBuilder.GetButton();
        }

        public Button CreateFullButton()
        {
            _directorFullButton.Builder = _buttonBuilder;
            _directorFullButton.BuildFullButton();
            return _buttonBuilder.GetButton();
        }

        public StringBuilder CreateTextFullButtonInfo()
        {
            _directorFullButton.Builder = _textButtonBuilder;
            _directorFullButton.BuildFullButton();
            return _textButtonBuilder.GetInfo();
        }

        public StringBuilder CreateTextMinimalButtonInfo() 
        {
            _directorMinimalButton.Builder = _textButtonBuilder;
            _directorMinimalButton.BuildMinimalButton();
            return _textButtonBuilder.GetInfo();
        }

        public StringBuilder CreateTextCancelButtonInfo()
        {
            _directorCancelButton.Builder = _textButtonBuilder;
            _directorCancelButton.BuildCancelButton();
            return _textButtonBuilder.GetInfo();
        }
    }
}
