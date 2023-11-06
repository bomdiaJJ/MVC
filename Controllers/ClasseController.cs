using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ClasseController : ControllerBase {

    [HttpGet]
    public ContentResult Get() {

        var htmlContent = string.Concat(
            "<h1>",
                "Classe ADS - 4 Ciclo, Noite",
            "</h1>",
            "<h3>",
                "Lista de Alunos",
            "</h3>",
            "<ul>",
                "<li>",
                    "Fulano",
                "</li>",
                "<li>",
                    "Ciclana",
                "</li>",
                "<li>",
                    "Beltrano",
                "</li>",
            "</ul>"
        );

        return base.Content(htmlContent, "text/html");
    }

}