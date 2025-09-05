using StorageValidation;

ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
conta.Sacar(1500); // inválido
conta.Sacar(800);  // válido