using ExcelExtractor.ViewModels;

namespace ExcelExtractor.Manager.Interface
{
    public interface IExtractorService
    {
        Task<List<ExcelModel>> SaveExcel(List<ExcelModel> models);
    }
}
