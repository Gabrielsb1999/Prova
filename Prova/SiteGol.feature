Feature: SiteGol
	Desenvolver uma automação que faça uma pesquisa de compra de passagem para 2
	adultos e selecione a menor tarifa do dia

Scenario: Compra de duas passagens para adultos com menor tarifa
	Given  que acesso o site "https://www.voegol.com.br/pt"
	When eu seleciono a origem como SDU
	And seleciono o destino como GRU
	And seleciono a data da ida um dia após o dia atual
	And seleciono a data de volta como 15 de agosto
	And adiciono dois adultos
	And clico no botão Compre Aqui
	Then seleciono a Menor tarifa do dia para voo de ida e voo de volta

Scenario: Compra de duas passagens para adultos com selecao de voo com horario mais proximo
	Given  que acesso o site "https://www.voegol.com.br/pt"
	When eu seleciono a origem como SDU
	And seleciono o destino como GRU
	And seleciono a data da ida um dia após o dia atual
	And seleciono a data de volta como 15 de agosto
	And adiciono dois adultos
	And clico no botão Compre Aqui
	Then seleciono a Menor tarifa do dia para voo de ida e voo de volta

Scenario: Compra de duas passagens para adultos em uma data diferente
	Given  que acesso o site "https://www.voegol.com.br/pt"
	When eu seleciono a origem como SDU
	And seleciono o destino como GRU
	And seleciono a data da ida um dia após o dia atual
	And seleciono a data de volta como 15 de agosto
	And adiciono dois adultos
	And clico no botão Compre Aqui
	Then seleciono a Menor tarifa do dia para voo de ida e voo de volta