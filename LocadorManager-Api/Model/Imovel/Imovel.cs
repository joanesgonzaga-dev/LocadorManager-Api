﻿using LocadorManager_Api.Model.Proprietarios;
using Newtonsoft.Json;

namespace LocadorManager_Api.Model.Imovel
{
    public class Imovel
    {
        public string id_filial_fil { get; set; }
        public string st_nome_fil { get; set; }

        [JsonIgnore]
        public List<ProprietariosBeneficiario> proprietarios_beneficiarios { get; set; }
        
        public List<Contrato> Contratos { get; set; }
        public List<Inquilino> Inquilinos { get; set; }
        
        [JsonIgnore]
        public List<Angariador> Angariadores { get; set; }
        public string id_imovel_imo { get; set; }
        public string st_identificador_imo { get; set; }
        public string vl_aluguel_imo { get; set; }
        public string vl_condominio_imo { get; set; }
        public string vl_parcelaiptu_imo { get; set; }
        public string st_tipo_imo { get; set; }
        public string st_codigoiptu_imo { get; set; }
        public string nm_parcelasiptu_imo { get; set; }
        public string nm_txiptuproprietario_imo { get; set; }
        public string nm_txiptuinquilino_imo { get; set; }
        public string fl_responsavelcondominio_imo { get; set; }
        public string st_cep_imo { get; set; }
        public string st_endereco_imo { get; set; }
        public string st_bairro_imo { get; set; }
        public string st_complemento_imo { get; set; }
        public string st_cidade_imo { get; set; }
        public string st_estado_imo { get; set; }
        public string st_numero_imo { get; set; }
        public string st_areautil_imo { get; set; }
        public string st_areatotal_imo { get; set; }
        public string nm_quartos_imo { get; set; }
        public string nm_suites_imo { get; set; }
        public string nm_banheiros_imo { get; set; }
        public string nm_salas_imo { get; set; }
        public string nm_varandas_imo { get; set; }
        public string nm_garagens_imo { get; set; }
        public string nm_piscinas_imo { get; set; }
        public string st_codagua_imo { get; set; }
        public string st_codenergia_imo { get; set; }
        public string st_codgas_imo { get; set; }
        public string st_observacao_imo { get; set; }
        public string st_cartorio_imo { get; set; }
        public string st_matriculacartorio_imo { get; set; }
        public string st_administradora_imo { get; set; }
        public string st_condominio_imo { get; set; }
        public string fl_responsaveliptu_imo { get; set; }
        public string fl_responsavelagua_imo { get; set; }
        public string nm_txaguaproprietario_imo { get; set; }
        public string nm_txaguainquilino_imo { get; set; }
        public string tx_locacao_imo { get; set; }
        public string nm_repassegarantido_imo { get; set; }
        public string fl_diafixorepasse_imo { get; set; }
        public string fl_status_imo { get; set; }
        public string tx_adm_imo { get; set; }
        public string fl_txadmvalorfixo_imo { get; set; }
        public string fl_txlocacaovalorfixo_imo { get; set; }
        public string nm_parcelastxlocacao_imo { get; set; }
        public string nm_diarepasse_imo { get; set; }
        public string vl_venda_imo { get; set; }
        public string st_codigosequencial_imo { get; set; }
        public string st_codigocidadedimob_imo { get; set; }
        public string st_tipodimob_imo { get; set; }
        public string st_identificadorimportacao_imo { get; set; }
        public string id_administradora_adm { get; set; }
        public string st_iptugaragem_imo { get; set; }
        public string st_sincrofilial_imo { get; set; }
        public string fl_split_imo { get; set; }
        public string id_foto_imo { get; set; }
        public string st_codigospu_imo { get; set; }
        public string id_gestor_imo { get; set; }
        public string st_txlixo_imo { get; set; }
        public string st_codbombeiro_imo { get; set; }
        public string id_condominio_cond { get; set; }
        public string st_avaliacao_imo { get; set; }
        public string st_detalhes_imo { get; set; }
        public string nm_meseslocacao_imo { get; set; }
        public string tx_anual_imo { get; set; }
        public string st_destinacao_imo { get; set; }
        public string nm_mesesisencaomulta_imo { get; set; }
        public string fl_imoveltombado_imo { get; set; }
        public string fl_tipoisencao_imo { get; set; }
        public string fl_admcondominio_imo { get; set; }
        public string fl_contapessoa_imo { get; set; }
        public string dt_contapessoa_imo { get; set; }
        public string dt_atualizacao_imo { get; set; }
        public string fl_motivorescisao_imo { get; set; }
        public string dt_rescisao_imo { get; set; }
        public string nm_txanualcobrarmes_imo { get; set; }
        public string fl_cobrartxanual_imo { get; set; }
        public string fl_txanualcobrarsemcontrato_imo { get; set; }
        public string fl_txanualcobrarproporcional_imo { get; set; }
        public string dt_entrada_imo { get; set; }
        public string fl_reembolsoiss_imo { get; set; }
        public string st_apelido_imo { get; set; }
        public string vl_txadmvalorminimo_imo { get; set; }
        public string id_integracaoimoveis_imo { get; set; }
        public string st_codigocontribuinte_imo { get; set; }
        public string fl_txanualcobrarvalordomes_imo { get; set; }
        public string fl_ligacaoeletrica_imo { get; set; }
        public string st_uuidassinaturapaybox_imo { get; set; }
        public string fl_ocultarowli_imo { get; set; }
        public string st_nome_cond { get; set; }
        public string nome_formatado { get; set; }
        public string nome_proprietario { get; set; }
        public string cnpj_proprietario { get; set; }
        public string id_proprietario { get; set; }
        public string nascimento_proprietario { get; set; }
        public string celular_proprietario { get; set; }
        public string email_proprietario { get; set; }
        public string detalhes_formatado { get; set; }
        public string identificador_formatado { get; set; }
        public string id_contrato_con { get; set; }
        public string id_sacado_sac { get; set; }
        public string nome_inquilino { get; set; }
        public string cnpj_inquilino { get; set; }
        public string id_inquilino { get; set; }
        public string situacao_imovel { get; set; }
        public string contrato_pendente { get; set; }
    }
}
