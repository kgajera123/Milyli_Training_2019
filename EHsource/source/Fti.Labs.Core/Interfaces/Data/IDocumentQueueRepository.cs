﻿using Fti.Labs.Core.Models;

namespace Fti.Labs.Core.Interfaces.Data
{
	public interface IDocumentQueueRepository
	{
		void Create(DocumentProcessingQueue documentProcessingQueue);

		DocumentProcessingQueue ReadNextFromQueue();
	}
}
