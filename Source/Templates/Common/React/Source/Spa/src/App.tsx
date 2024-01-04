import { useEffect, useState } from "react";

const App = () => {
	// https://designcode.io/react-hooks-handbook-fetch-data-from-an-api
	const [bffApiError, setBffApiError] = useState<string>();
	const [bffData, setBffData] = useState<string>();
	const [publicApiError, setPublicApiError] = useState<string>();
	const [publicData, setPublicData] = useState<string>();

	useEffect(() => {
		const fetchBffData = async () => {
			try {
				const response = await fetch("/bff/example/get", {
					headers: {
						"X-CSRF": "1",
					},
				});

				if (response.status === 200) {
					const value = await response.text();
					console.log(value);
					setBffData(value);
				}
				else {
					throw new Error(response.status + " - " + response.statusText);
				}
			} catch (error) {
				console.error(error);
				// https://kentcdodds.com/blog/get-a-catch-block-error-message-with-typescript
				const errorMessage: string = (error instanceof Error) ? error.message : String(error);
				setBffApiError(errorMessage);
			}
		};

		fetchBffData();

		const fetchPublicData = async () => {
			try {
				const response = await fetch("https://api.adviceslip.com/advice");

				if (response.status === 200) {
					const json = await response.json();
					console.log(json.slip.advice);
					setPublicData(json.slip.advice);
				}
				else {
					throw new Error(response.status + " - " + response.statusText);
				}
			} catch (error) {
				console.error(error);
				// https://kentcdodds.com/blog/get-a-catch-block-error-message-with-typescript
				const errorMessage: string = (error instanceof Error) ? error.message : String(error);
				setPublicApiError(errorMessage);
			}
		};

		fetchPublicData();
	}, []);
	return (
		<main className="container-sm">
			<h1>Home</h1>
			<h2>Bff api</h2>
			{bffData &&
				<div className="alert alert-info">
					<h3>Result</h3>
					<p>{bffData}</p>
				</div>
			}
			{bffApiError &&
				<div className="alert alert-danger">
					<h3>Error</h3>
					<p>{bffApiError}</p>
				</div>
			}
			<h2>Public api</h2>
			{publicData &&
				<div className="alert alert-info">
					<h3>Result</h3>
					<p>{publicData}</p>
				</div>
			}
			{publicApiError &&
				<div className="alert alert-danger">
					<h3>Error</h3>
					<p>{publicApiError}</p>
				</div>
			}
		</main>
	)
};

export default App;