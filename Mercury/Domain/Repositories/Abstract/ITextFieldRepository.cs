using Mercury.Domain.Entities;

namespace Mercury.Domain.Repositories.Abstract
{
	public interface ITextFieldRepository
	{
		IQueryable<TextField> GetTextFields();
		TextField GetTextFieldById(Guid id);
		TextField GetTextFieldByCodeWord(string codeword);
		void SaveTextField(TextField entity);
		void DeliteTextField(Guid id);
	}
}
