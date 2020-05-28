﻿using Core.AppContext;
using Core.IRepository;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class DocumentRepository : Methods<Document>, IDocumentRepository
    {
        public DocumentRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
