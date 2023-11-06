using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase {

    [HttpGet]
    public Aluno Get() {
        return new Aluno("Jorge", "12345", 8);
    }

}