namespace TestAPI_Pop
    {
    public class Apis
        {
        #region AgrupadorCliente
        public string POST_AgrupadorCliente_Listar_v1 = "/v1/AgrupadorCliente/Listar";
        public string GET_AgrupadorCliente_Selecionar_v1 = "/v1/AgrupadorCliente/Selecionar?";// Variáveis da API : "codigoEstabelecimento=1&codigoAgrupador=1
        public string POST_AgrupadorCliente_Incluir_v1 = "/v1/AgrupadorCliente/Incluir";
        public string PUT_AgrupadorCliente_Alterar_v1 = "/v1/AgrupadorCliente/Alterar";
        public string DEL_AgrupadorCliente_Excluir_v1 = "/v1/AgrupadorCliente/Excluir?"; // Variáveis da API : "codigoEstabelecimento=1&codigoAgrupador=1
        #endregion
        #region Almoxarifado
        public string Almoxarifado_Listar_v1 = "/v1/Almoxarifado/Listar?"; // Variáveis da API : "codigoEstabelecimento=1
        public string Almoxarifado_Selecionar_v1 = "/v1/Almoxarifado/Selecionar?"; // Variáveis da API : "codigoEstabelecimento=1&codigoAlmoxarifado=2
        public string Almoxarifado_Incluir_v1 = "/v1/Almoxarifado/Incluir";
        public string Almoxarifado_Alterar_v1 = "/v1/Almoxarifado/Alterar";
        public string Almoxarifado_Excluir_v1 = "/v1/Almoxarifado/Excluir?"; // Variáveis da API : codigoEstabelecimento=1&codigoAlmoxarifado=2
        public string Almoxarifado_MontarCombo_v1 = "/v1/Almoxarifado/MontarCombo?"; // Variáveis da API : codigoEstabelecimento=&tipo=
        public string Almoxarifado_MontarCombo_v2 = "/v2/Almoxarifado/MontarCombo?"; // Variáveis da API : cnpjEstabelecimento=34274233001508&tipos=0,1,2
        public string Almoxarifado_Restaurar_v1 = "/v1/Almoxarifado/Restaurar?"; // Variáveis da API : codigoEstabelecimento=1&codigoAlmoxarifado=2
        #endregion
        #region Anp
        public string Anp_Listar_v1 = "/v1/Anp/Listar";
        #endregion
        #region Bomba
        public string Bomba_Listar_v1 = "/v1/Bomba/Listar";
        public string Bomba_Selecionar_v1 = "/v1/Bomba/Selecionar?"; // Variáveis da API : codigoBomba=18&cnpjEstabelecimento=34274233001508
        public string Bomba_Incluir_v1 = "/v1/Bomba/Incluir";
        public string Bomba_Alterar_v1 = "/v1/Bomba/Alterar";
        public string Bomba_Excluir_v1 = "/v1/Bomba/Excluir?"; // Variáveis da API : codigoBomba=18&cnpjEstabelecimento=34274233001508
        public string Bomba_MontarCombo_v1 = "/v1/Bomba/MontarCombo?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Bomba_MontarComboPdvs_v1 = "/v1/Bomba/MontarComboPdvs?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Bomba_MontarComboFabricantes_v1 = "/v1/Bomba/MontarComboFabricantes?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        #endregion
        #region Banco
        public string Banco_Listar_v1 = "/v1/Banco/Listar";
        public string Banco_Selecionar_v1 = "/v1/Banco/Selecionar?"; // Variáveis da API : codigoBanco=69
        public string Banco_Incluir_v1 = "/v1/Banco/Incluir";
        public string Banco_Alterar_v1 = "/v1/Banco/Alterar";
        public string Banco_Excluir_v1 = "/v1/Banco/Excluir?"; // Variáveis da API : codigoBanco=99
        public string Banco_MontarComboTipoBanco_v1 = "/v1/Banco/MontarComboTipoBanco";
        #endregion
        #region Bico
        public string Bico_Listar_v1 = "/v1/Bico/Listar";
        public string Bico_Selecionar_v1 = "/v1/Bico/Selecionar?"; // Variáveis da API : codigoBico=49&cnpjEstabelecimento=34274233001508
        public string Bico_Incluir_v1 = "/v1/Bico/Incluir";
        public string Bico_Alterar_v1 = "/v1/Bico/Alterar";
        public string Bico_Excluir_v1 = "/v1/Bico/Excluir?"; // Variáveis da API : codigoBico=1&cnpjEstabelecimento=34274233001508
        public string Bico_MontarComboNiveisPreco_v1 = "/v1/Bico/MontarComboNiveisPreco?"; // Variáveis da API : codigoTanque=1&cnpjEstabelecimento=34274233001508
        #endregion
        #region CartaoComanda
        public string CartaoComanda_Mensagem_Listar_v1 = "/v1/CartaoComanda/Mensagem/Listar?"; // Variáveis da API : codigoEstabelecimento=1
        public string CartaoComanda_Listar_v1 = "/v1/CartaoComanda/Listar?"; // Variáveis da API : codigoEstabelecimento=1
        public string CartaoComanda_RestaurarEmLote_v1 = "/v1/CartaoComanda/RestaurarEmLote";
        public string CartaoComanda_Excluir_v1 = "/v1/CartaoComanda/Excluir";
        #endregion
        #region Contas
        public string Contas_Listar_v1 = "/v1/Contas/Listar";
        public string Contas_Selecionar_v1 = "/v1/Contas/Selecionar?"; // Variáveis da API : CnpjEstabelecimento=06224535000122&codigoConta=4000
        public string Contas_Incluir_v1 = "/v1/Contas/Incluir";
        public string Contas_Alterar_v1 = "/v1/Contas/Alterar";
        public string Contas_Excluir_v1 = "/v1/Contas/Excluir?"; // Variáveis da API : CnpjEstabelecimento=06224535000122&codigoConta=3000046
        public string Contas_SelecionarSubConta_v1 = "/v1/Contas/SelecionarSubConta?"; // Variáveis da API : CnpjEstabelecimento=17898787000153&codigoSubConta=7990239
        public string Contas_IncluirSubConta_v1 = "/v1/Contas/IncluirSubConta";
        public string Contas_AlterarSubConta_v1 = "/v1/Contas/AlterarSubConta";
        public string Contas_ExcluirSubConta_v1 = "/v1/Contas/ExcluirSubConta?"; // Variáveis da API : CnpjEstabelecimento=06224535000122&codigoSubConta=3000049
        public string Contas_MontarComboGrupo_v1 = "/v1/Contas/MontarComboGrupo";
        public string Contas_MontarComboTipoConta_v1 = "/v1/Contas/MontarComboTipoConta";
        public string Contas_MontarComboPagarReceber_v1 = "/v1/Contas/MontarComboPagarReceber";
        public string Contas_MontarComboReceitaDespesa_v1 = "/v1/Contas/MontarComboReceitaDespesa";
        public string Contas_MontarComboNaturezaSped_v1 = "/v1/Contas/MontarComboNaturezaSped";
        public string Contas_MontarComboIndicadorConta_v1 = "/v1/Contas/MontarComboIndicadorConta";
        public string Contas_MontarComboPlanoContaSPED_v1 = "/v1/Contas/MontarComboPlanoContaSPED?"; // Variáveis da API : tipoMovimentacao=D
        public string Contas_MontarComboPlanoContaFinanceiro_v1 = "/v1/Contas/MontarComboPlanoContaFinanceiro?"; // Variáveis da API : codigoTipoLancamento=1
        #endregion
        #region CentroMonetario
        public string CentroMonetario_Listar_v1 = "/v1/CentroMonetario/Listar";
        public string CentroMonetario_Selecionar_v1 = "/v1/CentroMonetario/Selecionar?"; // Variáveis da API : codigoCentroMonetario=230&cnpjEstabelecimento=06224535000122
        public string CentroMonetario_Incluir_v1 = "/v1/CentroMonetario/Incluir";
        public string CentroMonetario_Alterar_v1 = "/v1/CentroMonetario/Alterar";
        public string CentroMonetario_Excluir_v1 = "/v1/CentroMonetario/Excluir?";// Variáveis da API : codigoCentroMonetario=235&cnpjEstabelecimento=06224535000122
        #endregion
        #region Cest
        public string Cest_Listar_v1 = "/v1/Cest/Listar";
        #endregion
        #region Cnae
        public string Cnae_Listar_v1 = "/v1/Cnae/Listar";
        #endregion
        #region Configuracao
        public string Configuracao_Listar_v1 = "/v1/Configuracao/Listar";
        public string Configuracao_Atualizar_v1 = "/v1/Configuracao/Atualizar";
        #endregion
        #region ConferenciaTurno
        public string ConferenciaTurno_MontarComboSituacao_v1 = "/v1/ConferenciaTurno/MontarComboSituacao";
        public string ConferenciaTurno_MontarComboOperador_v1 = "/v1/ConferenciaTurno/MontarComboOperador?"; // Variáveis da API : periodoDe=2019-03-02T00:00:00&periodoAte=2019-03-03T00:00:00&cnpjEstabelecimento=17898787000153
        public string ConferenciaTurno_MontarComboMaquinas_v1 = "/v1/ConferenciaTurno/MontarComboMaquinas?"; // Variáveis da API : periodoDe=2019-03-02T00:00:00&periodoAte=2019-03-03T00:00:00&cnpjEstabelecimento=17898787000153
        public string ConferenciaTurno_ListarConferencias_v1 = "/v1/ConferenciaTurno/ListarConferencias";
        public string ConferenciaTurno_ListarTurnos_v1 = "/v1/ConferenciaTurno/ListarTurnos";
        public string ConferenciaTurno_ListarFormasPagamento_v1 = "/v1/ConferenciaTurno/ListarFormasPagamento";
        public string ConferenciaTurno_ListarDocumentosFiscais_v1 = "/v1/ConferenciaTurno/ListarDocumentosFiscais";
        public string ConferenciaTurno_Salvar_v1 = "/v1/ConferenciaTurno/Salvar";
        public string ConferenciaTurno_Conferir_v1 = "/v1/ConferenciaTurno/Conferir";
        public string ConferenciaTurno_Reabrir_v1 = "/v1/ConferenciaTurno/Reabrir?";// Variáveis da API : codigoEstabelecimento=17898787000153&codigoTurno=10&codigoUsuario=1
        #endregion
        #region Empresa
        public string Empresa_Listar_v1 = "/v1/Empresa/Listar";
        public string Empresa_Selecionar_v1 = "/v1/Empresa/Selecionar?"; // Variáveis da API : CNPJ=06224535000122&CodigoEmpresa=1
        public string Empresa_Incluir_v1 = "/v1/Empresa/Incluir";
        public string Empresa_Alterar_v1 = "/v1/Empresa/Alterar";
        public string Empresa_Excluir_v1 = "/v1/Empresa/Excluir?"; // Variáveis da API : CNPJ=52146717000140&CodigoEmpresa=1
        #endregion
        #region EstruturaCartao
        public string EstruturaCartao_Listar_v1 = "/v1/EstruturaCartao/Listar";
        public string EstruturaCartao_Selecionar_v1 = "/v1/EstruturaCartao/Selecionar?"; // Variáveis da API : cnpjEstabelecimento=34274233025865&codigo=118
        public string EstruturaCartao_Incluir_v1 = "/v1/EstruturaCartao/Incluir";
        public string EstruturaCartao_Alterar_v1 = "/v1/EstruturaCartao/Alterar";
        public string EstruturaCartao_Excluir_v1 = "/v1/EstruturaCartao/Excluir?"; // Variáveis da API : codigo=118
        public string EstruturaCartao_MontaComboRede_v1 = "/v1/EstruturaCartao/MontaComboRede?"; // Variáveis da API : somenteAtivas=true
        public string EstruturaCartao_MontaComboBandeira_v1 = "/v1/EstruturaCartao/MontaComboBandeira?"; // Variáveis da API : somenteAtivas=true
        public string EstruturaCartao_MontaComboProdutoRede_v1 = "/v1/EstruturaCartao/MontaComboProdutoRede?"; // Variáveis da API : codigoRede=1&somenteAtivas=true
        public string EstruturaCartao_Restaurar_v1 = "/v1/EstruturaCartao/Restaurar?"; // Variáveis da API : codigo=118
        public string EstruturaCartao_Reprocessar_v1 = "/v1/EstruturaCartao/Reprocessar";
        #endregion
        #region EstruturaMercadologica
        public string EstruturaMercadologica_Listar_v1 = "/v1/EstruturaMercadologica/Listar";
        public string EstruturaMercadologica_Incluir_v1 = "/v1/EstruturaMercadologica/Incluir";
        public string EstruturaMercadologica_Alterar_v1 = "/v1/EstruturaMercadologica/Alterar";
        public string EstruturaMercadologica_Excluir_v1 = "/v1/EstruturaMercadologica/Excluir?";// Variáveis da API : CnpjEstabelecimento=06224535000122&codigoEstrutura=1377
        public string EstruturaMercadologica_MontarCombo_v1 = "/v1/EstruturaMercadologica/MontarCombo";
        #endregion
        #region Estoque
        public string Estoque_Movimentacao_Justificativa_v1 = "/v1/Estoque/Movimentacao/Justificativa?"; // Variáveis da API : operacaoEstoque=3
        public string Estoque_Medicao_Listar_v1 = "/v1/Estoque/Medicao/Listar";
        public string Estoque_Consulta_v1 = "/v1/Estoque/Consulta";
        public string Estoque_ConsultaTotais_v1 = "/v1/Estoque/ConsultaTotais";
        public string Estoque_Movimentacao_Incluir_v1 = "/v1/Estoque/Movimentacao/Incluir";
        public string Estoque_Medicao_Salvar_v1 = "/v1/Estoque/Medicao/Salvar";
        public string Estoque_Movimentacao_OperacaoEstoque_v1 = "/v1/Estoque/Movimentacao/OperacaoEstoque";
        public string Estoque_Medicao_Excluir_v1 = "/v1/Estoque/Medicao/Excluir?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&codigo=1&dataMedicao=
        #endregion
        #region FaixaComissionamento
        public string FaixaComissionamento_Listar_v1 = "/v1/FaixaComissionamento/Listar?"; // Variáveis da API : codigoEstabelecimento=1
        public string FaixaComissionamento_Incluir_v1 = "/v1/FaixaComissionamento/Incluir";
        public string FaixaComissionamento_Alterar_v1 = "/v1/FaixaComissionamento/Alterar";
        public string FaixaComissionamento_Excluir_v1 = "/v1/FaixaComissionamento/Excluir?"; // Variáveis da API : codigoEstabelecimento=1&codigo=1
        #endregion
        #region FormasPagamento
        public string FormasPagamento_Listar_v1 = "/v1/FormasPagamento/Listar";
        public string FormasPagamento_Selecionar_v1 = "/v1/FormasPagamento/Selecionar?";// Variáveis da API : CodigoEstabelecimento=1&CodigoFormaPagamento=-5
        public string FormasPagamento_Incluir_v1 = "/v1/FormasPagamento/Incluir";
        public string FormasPagamento_Alterar_v1 = "/v1/FormasPagamento/Alterar";
        public string FormasPagamento_Excluir_v1 = "/v1/FormasPagamento/Excluir?";// Variáveis da API : CnpjEstabelecimento=06224535000122&CodigoFormaPagamento=14
        public string FormasPagamento_MontarCombo_v1 = "/v1/FormasPagamento/MontarCombo?"; // Variáveis da API : cnpjEstabelecimento=17898787000153
        #endregion
        #region FormaPagamento
        public string FormaPagamento_Selecionar_v1 = "/v1/FormaPagamento/Selecionar";
        public string FormaPagamento_Salvar_v1 = "/v1/FormaPagamento/Salvar";
        #endregion
        #region Financeiro
        public string Financeiro_ConsultaGerenciamento_v1 = "/v1/Financeiro/ConsultaGerenciamento";
        public string Financeiro_SelecionarTitulo_v1 = "/v1/Financeiro/SelecionarTitulo?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&codigoTipoLancamento=1&id=847859
        public string Financeiro_ContasPagarReceber_Incluir_v1 = "/v1/Financeiro/ContasPagarReceber/Incluir";
        public string Financeiro_ContasPagarReceber_Alterar_v1 = "/v1/Financeiro/ContasPagarReceber/Alterar";
        public string Financeiro_ContasPagarReceber_Quitacao_v1 = "/v1/Financeiro/ContasPagarReceber/Quitacao";
        public string Financeiro_ContasPagarReceber_Quitacao_Parcial_v1 = "/v1/Financeiro/ContasPagarReceber/Quitacao";
        public string Financeiro_ConsultarParcelas_v1 = "/v1/Financeiro/ConsultarParcelas?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&id=874988
        public string Financeiro_ExcluirRecorrencia_v1 = "/v1/Financeiro/ExcluirRecorrencia?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&codigoRecorrencia=874988&dataVencimento=2019-04-23
        public string Financeiro_ExcluirParcela_v1 = "/v1/Financeiro/ExcluirParcela?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&id=874988
        public string Financeiro_Estorno_v1 = "/v1/Financeiro/Estorno?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&codigoTipoLancamento=1&id=874988
        public string Financeiro_Transferencia_Incluir_v1 = "/v1/Financeiro/Transferencia/Incluir";
        public string Financeiro_Transferencia_Alterar_v1 = "/v1/Financeiro/Transferencia/Alterar";
        public string Financeiro_DespesasDiversas_Incluir_v1 = "/v1/Financeiro/DespesasDiversas/Incluir";
        public string Financeiro_DespesasDiversas_Alterar_v1 = "/v1/Financeiro/DespesasDiversas/Alterar";
        public string Financeiro_MontaComboTipoLancamento_v1 = "/v1/Financeiro/MontaComboTipoLancamento";
        public string Financeiro_MontaComboSituacao_v1 = "/v1/Financeiro/MontaComboSituacao";
        public string Financeiro_MontaComboTipoDocumento_v1 = "/v1/Financeiro/MontaComboTipoDocumento?"; // Variáveis da API : CodigoTipoLancamento=1
        public string Financeiro_MontaComboTipoOcorrencia_v1 = "/v1/Financeiro/MontaComboTipoOcorrencia";
        public string Financeiro_Consulta_v1 = "/v1/Financeiro/Consulta";
        public string Financeiro_ConsultaTotais_v1 = "/v1/Financeiro/ConsultaTotais";
        public string Financeiro_FluxoCaixa_Listar_v1 = "/v1/Financeiro/FluxoCaixa/Listar";
        public string Financeiro_FluxoCaixa_MontaComboTipoLancamento_v1 = "/v1/Financeiro/FluxoCaixa/MontaComboTipoLancamento";
        #endregion
        #region Funcionario
        public string Funcionario_Listar_v1 = "/v1/Funcionario/Listar";
        public string Funcionario_Selecionar_v1 = "/v1/Funcionario/Selecionar?";// Variáveis da API : codigoPessoa=1459&cnpjEstabelecimento=34274233001508
        public string Funcionario_Incluir_v1 = "/v1/Funcionario/Incluir";
        public string Funcionario_Alterar_v1 = "/v1/Funcionario/Alterar";
        public string Funcionario_Excluir_v1 = "/v1/Funcionario/Excluir?";// Variáveis da API : codigoPessoa=1459&cnpjEstabelecimento=34274233001508
        public string Funcionario_Verificar_v1 = "/v1/Funcionario/verificar?"; // Variáveis da API : cpf=36391895074&cnpjEstabelecimento=34274233001508
        #endregion
        #region GrupoImposto
        public string GrupoImposto_Listar_v1 = "/v1/GrupoImposto/Listar";
        public string GrupoImposto_Selecionar_v1 = "/v1/GrupoImposto/Selecionar?";// Variáveis da API : CnpjEstabelecimento=06224535000122&CodigoGrupo=6
        public string GrupoImposto_Incluir_v1 = "/v1/GrupoImposto/Incluir";
        public string GrupoImposto_Alterar_v1 = "/v1/GrupoImposto/Alterar";
        public string GrupoImposto_Excluir_v1 = "/v1/GrupoImposto/Excluir?"; // Variáveis da API : CnpjEstabelecimento=06224535000122&CodigoGrupo=1
        public string GrupoImposto_MontarComboImpostos_v1 = "/v1/GrupoImposto/MontarComboImpostos?"; // Variáveis da API : CnpjEstabelecimento=06224535000122
        public string GrupoImposto_MontarComboTipoAliquota_v1 = "/v1/GrupoImposto/MontarComboTipoAliquota";
        public string GrupoImposto_MontarComboTipoOperacao_v1 = "/v1/GrupoImposto/MontarComboTipoOperacao";
        public string GrupoImposto_MontarComboGrupoImpostos_v1 = "/v1/GrupoImposto/MontarComboGrupoImpostos?"; // Variáveis da API : CnpjEstabelecimento=06224535000122
        public string GrupoImposto_MontarComboNaturezaReceita_v1 = "/v1/GrupoImposto/MontarComboNaturezaReceita?"; // Variáveis da API : codigoTipoImposto=3&codigoSituacaoTributaria=4
        #endregion
        #region SituacaoTributaria
        public string SituacaoTributaria_MontarCombo_v1 = "/v1/SituacaoTributaria/MontarCombo?"; // Variáveis da API : codigoTipoImposto=1&EntradaSaida=0
        #endregion
        #region IntervencaoTecnica
        public string IntervencaoTecnica_Listar_v1 = "/v1/IntervencaoTecnica/Listar";
        public string IntervencaoTecnica_Alterar_v1 = "/v1/IntervencaoTecnica/Alterar";
        public string IntervencaoTecnica_Excluir_v1 = "/v1/IntervencaoTecnica/Excluir?"; // Variáveis da API : codigoEstabelecimento=3&codigoIntervencaoTecnica=3
        #endregion
        #region LMC
        public string LMC_Gerar_v1 = "/v1/LMC/Gerar";
        public string LMC_Listar_v1 = "/v1/LMC/Listar";
        public string LMC_LitarRecebido_v1 = "/v1/LMC/LitarRecebido?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&idLMC=9350
        public string LMC_MontarComboCombustivel_v1 = "/v1/LMC/MontarComboCombustivel?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&DataInicial=2019-01-01&DataFinal=2019-01-31
        public string LMC_MontaParametros_v1 = "/v1/LMC/MontaParametros?"; // Variáveis da API : cnpjEstabelecimento=17898787000153
        public string LMC_MontarComboTanque_v1 = "/v1/LMC/MontarComboTanque?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&Data=2019-01-01&codigoProduto=1
        public string LMC_IncluirRecebido_v1 = "/v1/LMC/IncluirRecebido";
        public string LMC_AlterarRecebido_v1 = "/v1/LMC/AlterarRecebido";
        public string LMC_ExcluirRecebido_v1 = "/v1/LMC/ExcluirRecebido?"; // Variáveis da API : cnpjEstabelecimento=&idLMC=&idLMCRecebido=
        public string LMC_Visualizar_v1 = "/v1/LMC/visualizar";
        #endregion
        #region Maquina
        public string Maquina_MontarCombo_v1 = "/v1/Maquina/MontarCombo?";// Variáveis da API : cnpjEstabelecimento=17898787000153
        public string Maquina_MontarComboTipoEquipamento_v1 = "/v1/Maquina/MontarComboTipoEquipamento?"; // Variáveis da API : cnpjEstabelecimento=17898787000153
        public string Maquina_MontarComboEquipamento_v1 = "/v1/Maquina/MontarComboEquipamento?"; // Variáveis da API : codigoTipoEquipamento=11
        public string Maquina_ListarMaquinasPerifericos_v1 = "/v1/Maquina/ListarMaquinasPerifericos";
        public string Maquina_IncluirMaquinasPerifericos_v1 = "/v1/Maquina/IncluirMaquinasPerifericos";
        public string Maquina_ExcluirMaquinasPerifericos_v1 = "/v1/Maquina/ExcluirMaquinasPerifericos?"; // Variáveis da API : CodigoMaquina=7&CnpjEstabelecimento=06224535000122
        public string Maquina_AtualizaMaquinasPerifericos_v1 = "/v1/Maquina/AtualizaMaquinasPerifericos";
        #endregion
        #region Municipio
        public string Municipio_MontarComboCidades_v1 = "/v1/Municipio/MontarComboCidades?"; // Variáveis da API : codigoUF=20
        #endregion
        #region Ncm
        public string Ncm_Listar_v1 = "/v1/Ncm/Listar";
        #endregion
        #region Pessoa
        public string POST_Pessoa_Listar_v1 = "/v1/Pessoa/Listar";
        public string GET_Pessoa_Selecionar_v1 = "/v1/Pessoa/Selecionar?"; // Variáveis da API : cnpjEstabelecimento=06224535000122&codigo=745
        public string POST_Pessoa_Incluir_v1 = "/v1/Pessoa/Incluir";
        public string PUT_Pessoa_Alterar_v1 = "/v1/Pessoa/Alterar";
        public string DEL_Pessoa_Excluir_v1 = "/v1/Pessoa/Excluir?"; // Variáveis da API : cnpjEstabelecimento=06224535000122&codigo=748
        public string GET_Pessoa_MontarCombo_v1 = "/v1/Pessoa/MontarCombo?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&classificacaoPessoa=3&codigoCategoria=0
        public string GET_Pessoa_MontarComboTipo_v1 = "/v1/Pessoa/MontarComboTipo";
        public string GET_Pessoa_MontarComboClassificacao_v1 = "/v1/Pessoa/MontarComboClassificacao";
        public string GET_Pessoa_MontarComboCategoria_v1 = "/v1/Pessoa/MontarComboCategoria?"; // Variáveis da API : classificacaoPessoa=2
        public string GET_Pessoa_Restaurar_v1 = "/v1/Pessoa/Restaurar?"; // Variáveis da API : cnpjEstabelecimento=06224535000122&codigo=748
        public string GET_Pessoa_Verificar_v1 = "/v1/Pessoa/verificar?"; // Variáveis da API : cnpjEstabelecimento=06224535000122&cpfCnpj=745
        #endregion
        #region PerfilAcesso
        public string PerfilAcesso_Listar_v1 = "/v1/PerfilAcesso/Listar";
        public string PerfilAcesso_Selecionar_v1 = "/v1/PerfilAcesso/Selecionar?"; // Variáveis da API : codigoPerfil=15
        public string PerfilAcesso_Incluir_v1 = "/v1/PerfilAcesso/Incluir";
        public string PerfilAcesso_Alterar_v1 = "/v1/PerfilAcesso/Alterar";
        public string PerfilAcesso_Excluir_v1 = "/v1/PerfilAcesso/Excluir?"; // Variáveis da API : codigoPerfil=1
        public string PerfilAcesso_Restaurar_v1 = "/v1/PerfilAcesso/Restaurar?"; // Variáveis da API : Search=TESTE DEV 04
        public string PerfilAcesso_SelecionarEstruturaPermissaoPadrao_v1 = "/v1/PerfilAcesso/SelecionarEstruturaPermissaoPadrao";
        public string PerfilAcesso_MontarComboPerfisAcesso_v1 = "/v1/PerfilAcesso/MontarComboPerfisAcesso";
        #endregion
        #region Produto
        public string Produto_Listar_v1 = "/v1/Produto/Listar";
        public string Produto_Selecionar_v1 = "/v1/Produto/Selecionar?"; // Variáveis da API : cnpjEstabelecimento=34274233001508&id=7939
        public string Produto_Incluir_v1 = "/v1/Produto/Incluir";
        public string Produto_Alterar_v1 = "/v1/Produto/Alterar";
        public string Produto_Excluir_v1 = "/v1/Produto/Excluir?"; // Variáveis da API : cnpjEstabelecimento=34274233001508&id=7939
        public string Produto_verificar_v1 = "/v1/Produto/verificar?"; // Variáveis da API : cnpjEstabelecimento=34274233001508&codigoProduto=654321
        public string Produto_MontarComboTipoProduto_v1 = "/v1/Produto/MontarComboTipoProduto";
        public string Produto_MontarComboSubtipoProduto_v1 = "/v1/Produto/MontarComboSubtipoProduto?";// Variáveis da API : codigoTipoProduto=1
        public string Produto_MontarComboSituacao_v1 = "/v1/Produto/MontarComboSituacao";
        public string Produto_MontarComboFormaReajustePreco_v1 = "/v1/Produto/MontarComboFormaReajustePreco";
        public string Produto_MontarComboProdutos_v1 = "/v1/Produto/MontarComboProdutos?"; // Variáveis da API : cnpjEstabelecimento=34274233001508&search=gasolina
        public string Produto_PrecosMargens_v1 = "/v1/Produto/2210/PrecosMargens?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Produto_NiveisPreco_v1 = "/v1/Produto/2210/NiveisPreco?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Produto_InformacoesFiscais_v1 = "/v1/Produto/2210/InformacoesFiscais?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Produto_Estoque_v1 = "/v1/Produto/2210/Estoque?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Produto_Fornecedores_v1 = "/v1/Produto/2210/Fornecedores?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Produto_Composicao_v1 = "/v1/Produto/2210/Composicao?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        #endregion
        #region Setor
        public string Setor_MontarCombo_v1 = "/v1/Setor/MontarCombo?"; // Variáveis da API : codigoEstabelecimento=1
        public string Setor_MontarCombo_v2 = "/v2/Setor/MontarCombo?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        #endregion
        #region Troco
        public string Troco_Listar_v1 = "/v1/Troco/Listar";
        public string Troco_Selecionar_v1 = "/v1/Troco/Selecionar?"; // Variáveis da API : CnpjEstabelecimento=06224535000122&CodigoFormaPagamento=-2&CodigoTroco=-5&TipoLimite=0
        public string Troco_Incluir_v1 = "/v1/Troco/Incluir";
        public string Troco_Alterar_v1 = "/v1/Troco/Alterar";
        public string Troco_Excluir_v1 = "/v1/Troco/Excluir?";// Variáveis da API : CnpjEstabelecimento=06224535000122&CodigoFormaPagamento=-2&CodigoTipoLimite=0&Codigo=-1
        public string Troco_MontarComboFormaPagamento_v1 = "/v1/Troco/MontarComboFormaPagamento?"; // Variáveis da API : cnpjEstabelecimento=17898787000153&codigoTipoFormaPagamento=1
        public string Troco_MontarComboTipoLimite_v1 = "/v1/Troco/MontarComboTipoLimite";
        #endregion
        #region Tanque // Verificar situação de variável
        static public string codigotanque = "0";

        public string Tanque_Listar_v1 = "/v1/Tanque/Listar";
        public string Tanque_Selecionar_v1 = "/v1/Tanque/Selecionar?"; // Variáveis da API : codigoTanque=20&cnpjEstabelecimento=34274233001508
        public string Tanque_Incluir_v1 = "/v1/Tanque/Incluir";
        public string Tanque_Alterar_v1 = "/v1/Tanque/Alterar";
        public string Tanque_Excluir_v1 = "/v1/Tanque/Excluir?"; // Variáveis da API : codigoTanque=21&cnpjEstabelecimento=34274233001508
        public string Tanque_MontarCombo_v1 = "/v1/Tanque/MontarCombo?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Tanque_MontarComboProdutosCombustivel_v1 = "/v1/Tanque/MontarComboProdutosCombustivel?"; // Variáveis da API : cnpjEstabelecimento=34274233001508
        public string Tanque_MontarComboTipoAlmoxarifadoCombustivel_v1 = "/v1/Tanque/MontarComboTipoAlmoxarifadoCombustivel";
        public string Tanque_Tanque_Estoque_v1 = "/v1/Tanque/" + codigotanque + "/Estoque";
        #endregion
        #region UnidadeMedida
        public string UnidadeMedida_MontarCombo_v1 = "/v1/UnidadeMedida/MontarCombo";
        #endregion
        #region UnidadeFederativa
        public string UnidadeFederativa_MontarComboUF_v1 = "/v1/UnidadeFederativa/MontarComboUF";
        #endregion
        #region VendasRealizadas
        public string VendasRealizadas_Consulta_v1 = "/v1/vendasRealizadas/Consulta";
        public string VendasRealizadas_ConsultaTotais_v1 = "/v1/vendasRealizadas/ConsultaTotais";
        #endregion
        }
    }
