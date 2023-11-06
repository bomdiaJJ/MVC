[Serializable]
public class Aluno {
    private string _nome = "Fulano";
    private string _registroMatricula = "00000";
    private int _notaFinal;

    public string Nome {
        get => _nome;
    }
    
    public string RegistroMatricula {
        get => _registroMatricula;
    }

    public int NotaFinal {
        get => _notaFinal;
    }

    public Aluno(string nome, string registroMatricula, int notaFinal) {
        _nome = nome;
        _registroMatricula = registroMatricula;
        _notaFinal = notaFinal;
    }
}