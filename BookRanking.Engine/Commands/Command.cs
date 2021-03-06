﻿using BookRanking.Engine.Commands.Contracts;
using BookRanking.Engine.Factories.Contracts;
using BookRanking.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRanking.Engine.Commands
{
    public abstract class Command: ICommand
    {
        protected readonly IDTOFactory DTOFactory;
       
        public Command(IDTOFactory DTOFactory)
        {
            this.DTOFactory = DTOFactory;
        }

        public abstract string Execute(IList<string> parameters);
    }
}
