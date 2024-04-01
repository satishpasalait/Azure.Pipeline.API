using Azure.Pipeline.API.Models;

namespace Azure.Pipeline.API.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        public IEnumerable<Document> GetDocuments()
        {
            return new List<Document>
            {
                new Document { Id = 1, Name = "File_1.pdf", Description = "File 1 Document", ClientName = "Aster Blossome", Source = "Manual Upload", FileName = "File_1.pdf", Status = "Archived", DocumentCategory = "Doc Category 2", DateCreated = DateTime.Now },
                new Document { Id = 2, Name = "File_2.pdf", Description = "File 2 Document", ClientName = "Aster Blossome", Source = "Manual Upload", FileName = "File_2.pdf", Status = "Archived", DocumentCategory = "Doc Category 1", DateCreated = DateTime.Now },
                new Document { Id = 2, Name = "File_3.pdf", Description = "File 3 Document", ClientName = "Aster Blossome", Source = "Manual Upload", FileName = "File_3.pdf", Status = "Archived", DocumentCategory = "Doc Category 2", DateCreated = DateTime.Now },
                new Document { Id = 2, Name = "File_4.pdf", Description = "File 4 Document", ClientName = "Aster Blossome", Source = "Manual Upload", FileName = "File_4.pdf", Status = "Archived", DocumentCategory = "Doc Category 3", DateCreated = DateTime.Now },
                new Document { Id = 2, Name = "File_5.pdf", Description = "File 5 Document", ClientName = "Aster Blossome", Source = "Manual Upload", FileName = "File_5.pdf", Status = "Archived", DocumentCategory = "Doc Category 4", DateCreated = DateTime.Now }
            };
        }
    }
}
